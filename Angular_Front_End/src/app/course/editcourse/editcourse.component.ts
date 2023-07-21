import { Component, OnInit } from '@angular/core';
import { DataService } from 'src/app/services/data.service';
import { Course } from 'src/app/shared/course';
import { Router, ActivatedRoute } from '@angular/router';
import { FormControl,FormGroup, Validators } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-editcourse',
  templateUrl: './editcourse.component.html',
  styleUrls: ['./editcourse.component.scss']
})

export class EditcourseComponent implements OnInit {

  CourseToEdit:Course = new Course(); //declare course to edit given empty object for updated course to be inserted into 
  constructor(private dataservice: DataService, private thisroute: Router, private currentroute: ActivatedRoute) { }

  //creating form to submit 
  EditForm: FormGroup = new FormGroup({
    name: new FormControl('',[Validators.required]),
    duration: new FormControl('',[Validators.required]),
    description: new FormControl('',[Validators.required])
  })

  ngOnInit(): void {
    //1. get Id using activated route 
    //2. find the data associated with id
    //3. map the response to the empty object
    //4. map data to the form

    this.currentroute.params.subscribe(params => {

      this.dataservice.GetCourse(params['id']).subscribe(result=>{

        this.CourseToEdit = result as Course;

        this.EditForm.controls['name'].setValue(this.CourseToEdit.name);
        this.EditForm.controls['duration'].setValue(this.CourseToEdit.duration);
        this.EditForm.controls['description'].setValue(this.CourseToEdit.description);
      })
    })      
  }

  //update edited course
  //1. declare new course object
  //2. get updated values from form
  //3. check status code from api
  EditCourse()
  {
    let editedcourse = new Course();
    
    editedcourse.name = this.EditForm.value.name;
    editedcourse.duration = this.EditForm.value.duration;
    editedcourse.description = this.EditForm.value.description;

    this.dataservice.EditCourse(this.CourseToEdit.courseId,editedcourse).subscribe((results:any)=>{
      console.log(results); 
      this.thisroute.navigate(['/']);
    })
  }
  
}


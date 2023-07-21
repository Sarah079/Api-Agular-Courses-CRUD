import { Component, OnInit } from '@angular/core';
import { DataService } from 'src/app/services/data.service';
import { Course } from 'src/app/shared/course';
import { Router } from '@angular/router';
import { FormControl,FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-addcourse',
  templateUrl: './addcourse.component.html',
  styleUrls: ['./addcourse.component.scss']
})
//1. declare new course
//2. create form 
//3. add course 
export class AddcourseComponent implements OnInit {
  courses: Course = new Course();
  constructor(private dataservice: DataService, private thisroute: Router) { }

  AddForm: FormGroup = new FormGroup({
    name: new FormControl('',[Validators.required]),
    duration: new FormControl('',[Validators.required]),
    description: new FormControl('',[Validators.required])
  })

  ngOnInit(): void {
  }

  AddCourse(){
    let addedcourse = new Course();

    addedcourse.name = this.AddForm.value.name;
    addedcourse.duration = this.AddForm.value.duration;
    addedcourse.description = this.AddForm.value.description;

    this.dataservice.AddCourse(addedcourse).subscribe((response:any) => {

      if(response.statusCode == 200)
      {
        this.thisroute.navigate(['/'])
      }
      else
      {
        alert(response.message);
      }
     });
  }
  
}

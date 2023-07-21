import { Component, OnInit } from '@angular/core'; //default
import { DataService } from '../services/data.service'; //added for data service
import { Course } from '../shared/course'; //added for us to use course.ts
import { Router } from '@angular/router';


@Component({
  selector: 'app-courses',
  templateUrl: './courses.component.html',
  styleUrls: ['./courses.component.scss']
})
//where logic takes place 
//1. declare courses
//2. instantiate dataservice and router
//3. get all courses
//4. edit route
//5. delete 
export class CoursesComponent implements OnInit {
  courses:Course[] = [] //empty array of type course - NB (= []) sets default

  constructor(private dataService: DataService, private thisroute:Router) { }

  ngOnInit(): void {
    this.GetCourses()
    console.log(this.courses)
  }

  GetCourses()
  {
    this.dataService.GetCourses().subscribe(result => {
      this.courses = result as Course[];

      //decided to use this ^^ beacuse I'm more used to for loops and calling the data in the "view"
      //console.log(result); //loging it  //let courseList:any[] = result   //courseList.forEach((element) => {       //this.courses.push(element)      //});
    })
  }
  EditCourse(courseId:Number)
  {
    this.thisroute.navigate(['/course', courseId]);
  }
  DeleteCourse(courseId:Number)
  {
    this.dataService.DeleteCourse(courseId).subscribe(result => {
      console.log(result); 
    })
  }
  reloadPage(){
    window.location.reload()
  }
}

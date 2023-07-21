import { Component } from '@angular/core';
import { Course } from '../app/shared/course';
import { Router } from '@angular/router';
import { DataService } from './services/data.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'assignment1';
  courses:Course[] = []


  constructor(private dataService: DataService, private router:Router) { }

  AddCourse()
  {
    this.router.navigate(['src/app\course\addcourse']);
  }

}


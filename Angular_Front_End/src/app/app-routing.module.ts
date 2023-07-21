import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
//to route to different pages import each component 
import { CoursesComponent } from './course/courses.component';
import { EditcourseComponent } from './course/editcourse/editcourse.component';
import { AddcourseComponent } from './course/addcourse/addcourse.component';

const routes: Routes = [
  {path: 'courses', component: CoursesComponent},  
  {path: '', redirectTo: '/courses', pathMatch: 'full'},
  {path: 'course/:id', component:EditcourseComponent}, //path to editcourse passing course id 
  {path: 'addcourse', component:AddcourseComponent}, //path to add course 
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ReactiveFormsModule } from '@angular/forms';
import { CoursesComponent } from './course/courses.component';
import { HttpClientModule } from '@angular/common/http';
import { EditcourseComponent } from './course/editcourse/editcourse.component';
import { AddcourseComponent } from './course/addcourse/addcourse.component';

@NgModule({
  declarations: [
    AppComponent,
    CoursesComponent,
    EditcourseComponent,
    AddcourseComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule, 
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map, Observable, Subject } from 'rxjs';
import { Course } from '../shared/course'; //added reference 

@Injectable({
  providedIn: 'root' 
})
export class DataService {

  apiUrl = 'http://localhost:5116/api/'

  httpOptions ={
    headers: new HttpHeaders({
      ContentType: 'application/json'
    })
  }

  constructor(private httpClient: HttpClient) { 
  }

  //get all
  //1. observable = let user see the data. any type.
  //2. return http.loacalhost:5116/api/Course/GetAllCourses
  GetCourses(): Observable<any>{ 
    return this.httpClient.get(`${this.apiUrl}Course/GetAllCourses`)
    .pipe(map(result => result))
  }

  //add
  AddCourse(course:Course){
    return this.httpClient.post(`${this.apiUrl}Course/AddCourse`, course)
    .pipe(map(result => result))
  }

  //get selected one
  GetCourse(courseId:Number){ 
    return this.httpClient.get(`${this.apiUrl}Course/GetCourse/${courseId}`) //during debugging changed from + courseid
    .pipe(map(result => result))
  }

  //edit
  EditCourse(courseId:Number, course:Course){
    return this.httpClient.put(`${this.apiUrl}Course/EditCourse/${courseId}`, course);
    //.pipe(map(result => result))
  }

  //delete 
  DeleteCourse(courseId:Number){
    return this.httpClient.delete(`${this.apiUrl}Course/DeleteCourse/${courseId}`);
    //.pipe(map(result => result))
  }

}



import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

/*
  AppComp
  */
export class AppComponent  implements OnInit{
  title = 'client';

  // "any" means that users can be any type, and we can change it later if we want
  // note this is considered unsafe
  users: any;

  constructor(private http: HttpClient){

  }

  ngOnInit(): void {
    throw new Error('Method not implemented.');
    this.http.get('https://localhost:5001/api/users').subscribe({{
      next: response => this.users = response,
      eorror: () =>
    }});
  } 

}

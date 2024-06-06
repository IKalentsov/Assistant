import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../environments/environment';

@Component({
  selector: 'app-general',
  templateUrl: './general.component.html',
  styleUrl: './general.component.css'
})
export class GeneralComponent implements OnInit {
  private _url = 'ping'

  constructor(
    private _http: HttpClient,
  ) {}

  ngOnInit(): void {
    this.get().subscribe((x: any) => {
      console.log(x);
    },
  error => {
    console.log(error);
  });
  }

  get(): Observable<any> {
    let test = this._http.get<any>(environment.urlAddress + this._url);

    return test;
  }
}

import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../environments/environment';
import { InputSelectComponent } from '../_platform/form/input-select/input-select.component';

@Component({
  standalone: true,
  selector: 'general',
  templateUrl: './general.component.html',
  styleUrl: './general.component.scss',
  imports: [InputSelectComponent],
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

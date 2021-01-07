import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ContactTypesService {

  private headers: HttpHeaders;
  private accessPointUrl: string = 'http://localhost:44397/api/ctypes';

  constructor(private http: HttpClient) {

    this.headers = new HttpHeaders({ 'Content-Type': 'application/json; charset=utf-8' });

  }

  public get() {

    return this.http.get(this.accessPointUrl, { headers: this.headers });
  }

  public add(contactType) {
    return this.http.post(this.accessPointUrl, contactType, { headers: this.headers });
  }

  public remove(contactType) {
    return this.http.delete(this.accessPointUrl + '/' + contactType.id, { headers: this.headers });
  }

  public update(contactType) {
    return this.http.put(this.accessPointUrl + '/' + contactType.id, contactType, { headers: this.headers });
  }

}

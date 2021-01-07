import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ContactsService {

  private headers: HttpHeaders;
  private accessPointUrl: string = 'http://localhost:44397/api/contacts';

  constructor(private http: HttpClient) {

    this.headers = new HttpHeaders({ 'Content-Type': 'application/json; charset=utf-8' });

  }

  public get() {

    return this.http.get(this.accessPointUrl, { headers: this.headers });
  }

  public add(contact) {
    return this.http.post(this.accessPointUrl, contact, { headers: this.headers });
  }

  public remove(contact) {
    return this.http.delete(this.accessPointUrl + '/' + contact.id, { headers: this.headers });
  }

  public update(contact) {
    return this.http.put(this.accessPointUrl + '/' + contact.id, contact, { headers: this.headers });
  }

}

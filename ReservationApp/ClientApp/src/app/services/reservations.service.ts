import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ReservationsService {

  private headers: HttpHeaders;
  private accessPointUrl: string = 'http://localhost:44397/api/reservations';


  constructor(private http: HttpClient) {

    this.headers = new HttpHeaders({ 'Content-Type': 'application/json; charset=utf-8' });

  }


  public get() {
    
    return this.http.get(this.accessPointUrl, { headers: this.headers });
  }

  public add(reservation) {
    return this.http.post(this.accessPointUrl, reservation, { headers: this.headers });
  }

  public remove(reservation) {
    return this.http.delete(this.accessPointUrl + '/' + reservation.id, { headers: this.headers });
  }

  public update(reservation) {
    return this.http.put(this.accessPointUrl + '/' + reservation.id, reservation, { headers: this.headers });
  }

}

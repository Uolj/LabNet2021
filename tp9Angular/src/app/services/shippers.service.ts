import { throwError as observableThrowError, Observable } from 'rxjs';

import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Shipper } from '../models/Shipper.model';
import { catchError } from 'rxjs/operators';

@Injectable({
  providedIn: 'root',
})
export class ShippersService {
  endpoint: string = 'ShippersApi/';
  url = environment.shippersApi + this.endpoint;

  constructor(private http: HttpClient) {}

  public addShipper(shipperRequest: Shipper): Observable<any> {
    return this.http
      .post(this.url, shipperRequest)
      .pipe(catchError(this.errorHandler));
  }

  public getShippers(): Observable<Array<Shipper>> {
    return this.http
      .get<Array<Shipper>>(this.url)
      .pipe(catchError(this.errorHandler));
  }

  public updateShipper(shipperRequest: Shipper): Observable<any> {
    return this.http
      .put<any>(this.url + shipperRequest.ShipperID, shipperRequest)
      .pipe(catchError(this.errorHandler));
  }

  public deleteShipper(shipperID: number) {
    return this.http
      .delete<any>(this.url + shipperID)
      .pipe(catchError(this.errorHandler));
  }

  errorHandler(error: HttpErrorResponse) {
    return observableThrowError(error.message || 'Server Error');
  }
}

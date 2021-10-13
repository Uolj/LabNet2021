import { Injectable } from '@angular/core';
import { Shipper } from '../models/Shipper.model';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class ShipperInfoService {
  private shipperInfo = new BehaviorSubject<Shipper>(new Shipper());
  public shipperInfo$ = this.shipperInfo.asObservable();

  constructor() {}

  sendShipper(shipper: Shipper) {
    this.shipperInfo.next(shipper);
  }
}

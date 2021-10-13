import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Shipper } from '../models/Shipper.model';
import { ShipperInfoService } from '../services/shipper-info.service';
import { ShippersService } from '../services/shippers.service';

@Component({
  selector: 'app-shippers-table',
  templateUrl: './shippers-table.component.html',
  styleUrls: ['./shippers-table.component.scss'],
})
export class ShippersTableComponent implements OnInit {
  public shippersList: Array<Shipper> = [];
  constructor(
    private router: Router,
    private shippersService: ShippersService,
    private shipperInfo: ShipperInfoService
  ) {}

  ngOnInit(): void {
    this.getShippers();
  }

  getShippers() {
    this.shippersService.getShippers().subscribe(
      (response) => (this.shippersList = response),
      (error) => alert(`unable to read database, ${error}`)
    );
  }

  deleteShipper(shipperID: number) {
    this.shippersService.deleteShipper(shipperID).subscribe(
      () => this.ngOnInit(),
      (error) => alert(`you cannot delete this record, ${error}`)
    );
  }

  takeShipperToUpdate(shipper: Shipper) {
    this.shipperInfo.sendShipper(shipper);
    this.btnRedirectToAdd();
  }

  btnRedirectToAdd() {
    this.router.navigateByUrl('/AddShipper');
  }
}

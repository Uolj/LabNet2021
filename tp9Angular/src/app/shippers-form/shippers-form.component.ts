import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Shipper } from '../models/Shipper.model';
import { ShippersService } from '../services/shippers.service';
import { ShipperInfoService } from '../services/shipper-info.service';

@Component({
  selector: 'app-shippers-form',
  templateUrl: './shippers-form.component.html',
  styleUrls: ['./shippers-form.component.scss'],
})
export class ShippersFormComponent implements OnInit {
  public shippersGroup: FormGroup;
  public newshipper: Shipper = new Shipper();
  public shipperToUpdate: Shipper;

  constructor(
    private formBuilder: FormBuilder,
    private router: Router,
    private shippersService: ShippersService,
    private shipperInfo: ShipperInfoService
  ) {}

  get formControls() {
    return this.shippersGroup.controls;
  }

  ngOnInit(): void {
    this.shipperInfo.shipperInfo$.subscribe(
      (info) => (this.shipperToUpdate = info)
    );
    this.initForm();

    this.formControls.companyName.setValue(this.shipperToUpdate.CompanyName);
    this.formControls.phoneNumber.setValue(this.shipperToUpdate.Phone);
  }

  initForm() {
    this.shippersGroup = this.formBuilder.group({
      companyName: ['', [Validators.required, Validators.maxLength(40)]],
      phoneNumber: ['', [Validators.required, Validators.maxLength(24)]],
    });
  }

  addShipper() {
    this.newshipper.CompanyName = this.formControls.companyName.value;
    this.newshipper.Phone = this.formControls.phoneNumber.value;
    this.shippersService.addShipper(this.newshipper).subscribe(
      () => this.btnBack(),
      (error) => alert(`Failed to add a new record, ${error}`)
    );
  }

  updateShipper() {
    this.shipperToUpdate.CompanyName = this.formControls.companyName.value;
    this.shipperToUpdate.Phone = this.formControls.phoneNumber.value;

    this.shippersService.updateShipper(this.shipperToUpdate).subscribe(
      () => this.btnBack(),
      (error) => alert(`An update to a record failed, ${error}`)
    );
  }

  btnBack() {
    this.shipperInfo.sendShipper(new Shipper());
    this.router.navigateByUrl('');
  }
}

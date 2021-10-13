import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ShippersFormComponent } from './shippers-form/shippers-form.component';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { MatTableModule } from '@angular/material/table';
import { ShippersTableComponent } from './shippers-table/shippers-table.component';
import { Router } from '@angular/router';
import { Shipper } from './models/Shipper.model';
import { HttpClientModule } from '@angular/common/http';
import { ShipperInfoService } from './services/shipper-info.service';

@NgModule({
  declarations: [AppComponent, ShippersFormComponent, ShippersTableComponent],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatFormFieldModule,
    MatInputModule,
    MatSelectModule,
    ReactiveFormsModule,
    CommonModule,
    MatTableModule,
    HttpClientModule,
  ],
  exports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatFormFieldModule,
    MatInputModule,
    MatSelectModule,
    ReactiveFormsModule,
    CommonModule,
    MatTableModule,
  ],
  entryComponents: [ShippersFormComponent, ShippersTableComponent],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}

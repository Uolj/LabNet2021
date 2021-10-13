import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { ShippersFormComponent } from './shippers-form/shippers-form.component';
import { ShippersTableComponent } from './shippers-table/shippers-table.component';

const routes: Routes = [
  {
    path: '',
    component: ShippersTableComponent,
  },
  {
    path: 'AddShipper',
    component: ShippersFormComponent,
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}

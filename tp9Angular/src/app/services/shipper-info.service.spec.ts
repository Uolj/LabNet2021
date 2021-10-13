import { TestBed } from '@angular/core/testing';

import { ShipperInfoService } from './shipper-info.service';

describe('ShipperInfoService', () => {
  let service: ShipperInfoService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ShipperInfoService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

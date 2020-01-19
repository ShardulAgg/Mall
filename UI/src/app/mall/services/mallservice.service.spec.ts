import { TestBed } from '@angular/core/testing';

import { MallserviceService } from './mallservice.service';

describe('MallserviceService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: MallserviceService = TestBed.get(MallserviceService);
    expect(service).toBeTruthy();
  });
});

import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { NavLoginSetupComponent } from './nav-login-setup.component';

describe('NavLoginSetupComponent', () => {
  let component: NavLoginSetupComponent;
  let fixture: ComponentFixture<NavLoginSetupComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NavLoginSetupComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NavLoginSetupComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

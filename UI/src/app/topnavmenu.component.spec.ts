import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TopnavmenuComponent } from './topnavmenu.component';

describe('TopnavmenuComponent', () => {
  let component: TopnavmenuComponent;
  let fixture: ComponentFixture<TopnavmenuComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TopnavmenuComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TopnavmenuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { Component, OnInit,Input } from '@angular/core';


@Component({
  selector: 'navigator',
  templateUrl: './navigator.component.html',
  styleUrls: ['./navigator.component.css']
})
export class NavigatorComponent  {

  
  @Input() titlePage  = "";

}

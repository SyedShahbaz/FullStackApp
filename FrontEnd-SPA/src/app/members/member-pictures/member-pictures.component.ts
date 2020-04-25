import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-member-pictures',
  templateUrl: './member-pictures.component.html',
  styleUrls: ['./member-pictures.component.css']
})
export class MemberPicturesComponent implements OnInit {

  @Input() images;
  constructor() { }

  ngOnInit() {
  }

}

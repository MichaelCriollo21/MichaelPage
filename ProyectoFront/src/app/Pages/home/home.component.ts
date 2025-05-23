import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { ClienteSelectComponent } from '../../Components/cliente-select/cliente-select.component';

@Component({
  standalone: true,
  selector: 'app-home',
  imports: [CommonModule, ClienteSelectComponent],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {

}

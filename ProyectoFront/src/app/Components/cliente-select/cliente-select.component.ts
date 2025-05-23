import { ChangeDetectionStrategy, Component, OnInit } from '@angular/core';
import { ClienteService } from '../../Services/cliente.service';
import { Cliente } from '../../Interface/cliente';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-cliente-select',
  imports: [CommonModule],
  templateUrl: './cliente-select.component.html',
  styleUrl: './cliente-select.component.css',
  standalone: true,
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class ClienteSelectComponent implements OnInit {

  listaClientes: Cliente[] = [];
  cliente: Cliente = {id: 0, razonSocial: '', idTipoCliente: 0, fechaCreacion: new Date(), rFC: ''}
   constructor(private clienteService: ClienteService) {}

  ngOnInit(): void {
    this.clienteService.getAll().subscribe(data => this.listaClientes = data);
  }
}

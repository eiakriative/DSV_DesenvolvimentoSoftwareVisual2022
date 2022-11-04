import { Console } from 'console';
import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Funcionario } from 'src/app/models/Funcionario';

@Component({
  selector: 'app-listar-funcionarios',
  templateUrl: './listar-funcionarios.component.html',
  styleUrls: ['./listar-funcionarios.component.css']
})
export class ListarFuncionariosComponent implements OnInit {

  funcionarios!: Funcionario[];

  constructor(private http : HttpClient) {} 

  ngOnInit(): void {
    this.http.get<Funcionario[]>
    ("https://localhost:5001/api/funcionario/listar")
    // Execução da requisição
    .subscribe({
      next: (funcionarios) => {
        for (const funcionario in funcionarios) {
          console.log(funcionario)
          
        }
        this.funcionarios = funcionarios;
      }
    });
  }

  remover(id: number): void{
    this.http.delete<Funcionario>
      (`https://localhost:5001/api/funcionario/deletar/${id}`)
      .subscribe({
        next: (funcionario) => {
          this.ngOnInit();
        }
      });
    }

}

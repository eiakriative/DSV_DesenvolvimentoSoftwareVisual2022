import { ListarFuncionariosComponent } from './components/pages/funcionario/listar-funcionarios/listar-funcionarios.component';
import { CadastrarFuncionarioComponent } from './components/pages/funcionario/cadastrar-funcionario/cadastrar-funcionario.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: "pages/funcionario/cadastrar",
    component: CadastrarFuncionarioComponent
  },
  {
    path: "pages/funcionario/listar",
    component: ListarFuncionariosComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

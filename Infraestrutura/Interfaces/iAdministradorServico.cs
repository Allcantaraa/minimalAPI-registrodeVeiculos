using MinimalApi.Dominio.Entidades;
using MinimalApi.DTOs;

namespace MinimalApi.Interfaces;

public interface iAdministradorServico
{
  Administrador? Login(LoginDTO loginDTO);

  Administrador Incluir(Administrador administrador);

  List<Administrador> Todos(int? pagina);
  Administrador? BuscaPorId(int id);
}
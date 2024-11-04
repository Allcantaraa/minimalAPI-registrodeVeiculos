using MinimalApi.Dominio.Entidades;
using MinimalApi.DTOs;

namespace MinimalApi.Interfaces;

public interface IVeiculoServico
{
  List<Veiculo> Todos(int? pagina, string? nome = null, string? marca = null);
  Veiculo? BuscaPorId(int id);

  void Incluir(Veiculo veiculo);

  void Atualizar(Veiculo veiculo);

  void Apagar(Veiculo veiculo);
}
using Cognizant.Domain.Interfaces;
using System.Collections.Generic;
using Cognizant.Domain.Entities;
using System.Linq;

namespace Cognizant.App
{
    public class AppTransacao : IRepositoryTransacao
    {
        private readonly IRepositoryTransacao repo;
        public AppTransacao(IRepositoryTransacao _repo)
        {
            repo = _repo;
        }
        public void Add(Transacao obj)
        {
            repo.Add(obj);
        }

        public IEnumerable<Transacao> BuscarExtrato(int id)
        {
            var extrato = repo.BuscarExtrato(id);
            return FormataExtrato(extrato);
        }

        public IEnumerable<Transacao> GetAll()
        {
            return repo.GetAll();
        }

        public Transacao GetById(int id)
        {
            return repo.GetById(id);
        }

        public void Remove(Transacao obj)
        {
            repo.Remove(obj);
        }

        public void Update(Transacao obj)
        {
            repo.Update(obj);
        }

        public IEnumerable<Transacao> FormataExtrato(IEnumerable<Transacao> extrato)
        {
            List<Transacao> extratoFormatado = new List<Transacao>();
            var dataContainer = extrato.ToList().First().Agendamento;
            var linha = "";
            bool dataNaoApresentada = true;
            for (int i = 0; i < extrato.Count(); i++)
            {
                if (dataContainer.ToString("dd/MM/yyyy") != 
                    extrato.ToList()[i].Agendamento.ToString("dd/MM/yyyy"))
                {
                    dataContainer = extrato.ToList()[i].Agendamento;
                    dataNaoApresentada = true;
                }
                if (dataNaoApresentada)
                {
                    linha = "       ";
                    linha += dataContainer.ToString("dd/MM/yyyy");
                    dataNaoApresentada = false;
                    i--;
                }
                else
                {
                    linha = "";
                    switch (extrato.ToList()[i].Tipo)
                    {
                        case "Compra":
                            linha += "--R$";
                            linha += extrato.ToList()[i].Valor;
                            linha += " ";
                            linha += extrato.ToList()[i].Observacao;
                            break;
                        case "Transferência":
                            linha += "--R$";
                            linha += extrato.ToList()[i].Valor;
                            linha += " ";
                            linha += "DOC/TED para conta";
                            linha += " ";
                            linha += extrato.ToList()[i].ContaIdTransferencia;
                            break;
                        case "Depósito":
                            linha += "R$";
                            linha += extrato.ToList()[i].Valor;
                            linha += " ";
                            linha += "Depósito";
                            break;
                        case "Pagamento":
                            linha += "--R$";
                            linha += extrato.ToList()[i].Valor;
                            linha += " ";
                            linha += extrato.ToList()[i].Observacao;
                            break;
                        default:
                            break;
                    }
                }
                var tr = new Transacao
                {
                    Observacao = linha
                };
                extratoFormatado.Add(tr);
            }
            return extratoFormatado;
        }
    }
}

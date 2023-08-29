using bytebank_ATENDIMENTO.bytebank.Atendimento;
using bytebank_GeradorChavePix;
using bytebank_Modelos.bytebank.Modelos.ADM.Utilitario;

// Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
//new ByteBankAtendimento().AtendimentoCliente();



var listaChaves = GeradorPix.GetChavesPix(10);

foreach(var chave in listaChaves)
{
    Console.WriteLine(GeradorPix.GetChavePix());
}
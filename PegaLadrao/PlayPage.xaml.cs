

using Microsoft.Maui.Controls;

namespace PegaLadrao;

List<HistoriaTFR> historia = new List<HistoriaTFR>();
public partial class PlayPage : ContentPage
{
	public PlayPage()
	{
		InitializeComponent();

	historia.Add(new HistoriaTFR()
    {
      Id = 0,
      Texto = "caramba",
      Aresposta=false
    });

	void Iniciar()
  {
    TrocaHistoryStepAtual(0);
  }

  //------------------------------------------------------------------------------------------------

  void PreencherPagina()
  {
    labelTexto.Text = historia.Texto;

    if (historia.JogadorF)
      frameperdeu.IsVisible = true;
    else
      frameperdeu.IsVisible = false;

    if (historia.TemResposta)
    {
      BotaoProximo.IsVisible = false;
      ClicaButao1.IsVisible = true;
      ClicaButao2.IsVisible = true;
      ClicaButao3.IsVisible = true;

      ClicaButao1.Text = historia.TextoR0;
      ClicaButao2.Text = historia.TextoR1;
      ClicaButao3.Text = historia.TextoR2;
    }
    else
    {
      BotaoProximo.IsVisible = true;
      ClicaButao1.IsVisible = false;
      ClicaButao2.IsVisible = false;
      ClicaButao3.IsVisible = false;
    }
  }

  void frameperdeu()
  {

  }

  //------------------------------------------------------------------------------------------------

  void TrocaHistoryStepAtual(int id)
  {
    historia = historia.Where(d => d.Id == id).First();
    PreencherPagina();
  }

  //------------------------------------------------------------------------------------------------

  void ButaofunfaProximo(object sender, EventArgs args)
  {
    var proximoId = historia.Id + 1;
    TrocaHistoryStepAtual(proximoId);
  }

  //------------------------------------------------------------------------------------------------

  void Butaofunfa1(object sender, EventArgs args)
  {
    TrocaHistoryStepAtual(historia.Resposta0);
  }

  //------------------------------------------------------------------------------------------------

  void Butaofunfa2(object sender, EventArgs args)
  {
    TrocaHistoryStepAtual(historia.Resposta1);
  }

  //------------------------------------------------------------------------------------------------

  void Butaofunfa3(object sender, EventArgs args)
  {
    TrocaHistoryStepAtual(historia.Resposta2);
  }

  //------------------------------------------------------------------------------------------------
  
	}

	

	
}

using Microsoft.Maui.Controls;

namespace PegaLadrao;


public partial class PlayPage : ContentPage
{
  List<HistoriaTFR> historia = new List<HistoriaTFR>();
  HistoriaTFR historiaatual;

	public PlayPage()
	{
		InitializeComponent();
//------------------------------------------------------------------------------------------------\\
	historia.Add(new HistoriaTFR()
    {
      Id = 0,
      Texto = "caramba",
      Aresposta=false
    });

    Iniciar();
//------------------------------------------------------------------------------------------------\\
	void Iniciar()
  {
    TrocaHistoryStepAtual(0);
  }

  //------------------------------------------------------------------------------------------------

  void PreencherPagina()
  {
    OTextoDoJogo.Text = historiaatual.Texto;
    if (historiaatual.JogadorF)
    {
      frameperdeu.IsVisible=true;
    }
    else
    {
      frameperdeuIsVisble=false;
    }


    if (historiaatual.TemResposta)
    {
      BotaoProximo.IsVisible = false;
      ClicaButao1.IsVisible = true;
      ClicaButao2.IsVisible = true;
      ClicaButao3.IsVisible = true;

      ClicaButao1.Text = historiaatual.TextoR0;
      ClicaButao2.Text = historiaatual.TextoR1;
      ClicaButao3.Text = historiaatual.TextoR2;
    }
    else
    {
      BotaoProximo.IsVisible = true;
      ClicaButao1.IsVisible = false;
      ClicaButao2.IsVisible = false;
      ClicaButao3.IsVisible = false;
    }
  }
//------------------------------------------------------------------------------------------------\\
 

//------------------------------------------------------------------------------------------------\\

  void TrocaHistoryStepAtual(int id)
  {
    historiaatual = historia.Where(d=> d.Id == id).First();
    PreencherPagina();
  }

//------------------------------------------------------------------------------------------------\\

  void ButaofunfaProximo(object sender, EventArgs args)
  {
    var proximoId = historiaatual.Id + 1;
    TrocaHistoryStepAtual(proximoId);
  }

//------------------------------------------------------------------------------------------------\\

  void Butaofunfa1(object sender, EventArgs args)
  {
    TrocaHistoryStepAtual(historiaatual.Resposta0);
  }

//------------------------------------------------------------------------------------------------\\

  void Butaofunfa2(object sender, EventArgs args)
  {
    TrocaHistoryStepAtual(historiaatual.Resposta1);
  }

//------------------------------------------------------------------------------------------------\\

  void Butaofunfa3(object sender, EventArgs args)
  {
    TrocaHistoryStepAtual(historiaatual.Resposta2);
  }

//------------------------------------------------------------------------------------------------\\
  
	}
}

using Microsoft.Maui.Controls;

namespace PegaLadrao;


public partial class PlayPage : ContentPage
{
  List<HistoriaTFR> historia = new List<HistoriaTFR>();
  HistoriaTFR historiaatual;

	public PlayPage()
	{
		InitializeComponent();

    Iniciar();
//------------------------------------------------------------------------------------------------\\
	historia.Add(new HistoriaTFR()
    {
      Id = 0,
      Texto = "caramba",
      Aresposta=false
    });

    historia.Add(new HistoriaTFR()
    {
      Id = 1,
      Texto = "caramjiiniba",
      TextoR0 = "jorijv khbnvk",
      TextoR1 = "jorgtrh6j7kmnyhtbt6k8khbnvk",
      TextoR2 = "johgfrtfdxesdfcxszesrdtf",

      Resposta0 = 10000,
      Resposta1 = 1999,
      Resposta2 = 20000,

      Aresposta=true
    });
    historia.Add(new HistoriaTFR()
    {
      Id = 10000,
      JogadorF = true,

      Aresposta=false
    });

    historia.Add(new HistoriaTFR()
    {
      Id = 1999,
      JogadorF = true,

      Aresposta=false
    });

    historia.Add(new HistoriaTFR()
    {
      Id = 20000,
      JogadorF = true,

      Aresposta=false
    });

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
      frameperdeu.IsVisible=false;
    }


    if (historiaatual.Aresposta)
    {
      ButaofunfaProximo.IsVisible = true;
      Butaofunfa1.IsVisible = false;
      
      Butaofunfa3.IsVisible = false;

      Butaofunfa1.Text = historiaatual.TextoR0;
      
      Butaofunfa3.Text = historiaatual.TextoR2;
    }
    else
    {
      ButaofunfaProximo.IsVisible = false;
      Butaofunfa1.IsVisible = true;
      
      Butaofunfa3.IsVisible = true;
    }
  }
//------------------------------------------------------------------------------------------------\\
 

//------------------------------------------------------------------------------------------------\\

  void TrocaHistoryStepAtual(int id)
  {
    historiaatual = historia.Where(d=> d.Id == id).First();
    PreencherPagina();
  };

//------------------------------------------------------------------------------------------------\\

  void ClicaButao0(object sender, EventArgs args)
  {
    var proximoId = historiaatual.Id + 1;
    TrocaHistoryStepAtual(proximoId);
  };

//------------------------------------------------------------------------------------------------\\

  void ClicaButao1(object sender, EventArgs args)
  {
    TrocaHistoryStepAtual(historiaatual.Resposta0);
  }

//------------------------------------------------------------------------------------------------\\

  void ClicaButao2(object sender, EventArgs args)
  {
    TrocaHistoryStepAtual(historiaatual.Resposta1);
  }

//------------------------------------------------------------------------------------------------\\

  void ClicaButao3(object sender, EventArgs args)
  {
    TrocaHistoryStepAtual(historiaatual.Resposta2);
  }

//------------------------------------------------------------------------------------------------\\
	}
}

using System.Security.Cryptography.X509Certificates;
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
      Texto = "eai detetive, como etá? precisamos da sua ajuda para solucionar um caso, podemos contar com você?",
      TextoR0 = "pó deixar com o pai",
      TextoR1 = "não to já fazendo uns paranaue",
      Resposta0 = 1,
      Resposta1 = -1,
      Aresposta=true
    });

    historia.Add(new HistoriaTFR()
    {
      Id = 1,
      Texto = "bom, então vamos começar vendo as pistas que obtemos, escolha uma",
      TextoR0 = "(faca com sangue)",
      TextoR1 = "(testemunha)",
      TextoR2 = "(camera)",

      Resposta0 = 2,
      Resposta1 = 3,
      Resposta2 = 4,

      Aresposta=true
    });

    historia.Add(new HistoriaTFR()
    {
      Id = 2,
      Texto = "não foi encontrado nem uma digital ou DNA do assasino",
      TextoR0 = "(ver as outras pistas)",

      Resposta0 = 1,

      Aresposta=true
    });

    historia.Add(new HistoriaTFR()
    {
      Id = 4,
      Texto = "a camera não funciona",
      TextoR0 = "(ver as outras pistas)",

      Resposta0 = 1,

      Aresposta=true
    });

    historia.Add(new HistoriaTFR()
    {
      Id = 3,
      Texto = "*(você) boa noite, oque você viu me fale                                *(vitima) eu vi um cara um pouco maior que eu brigando com uma mulher eles estávão gritando um com o outro estávão falando",
      TextoR0 = "(você) oque estavão falando?",
 

      Resposta0 = 2,
      Resposta1 = 3,
      Resposta2 = 4,

      Aresposta=true
    });


    

    //=========================================================================================\\

    historia.Add(new HistoriaTFR()
    {
      Id = -1,
      JogadorF = true,
      Resposta0 = 0
    });

    historia.Add(new HistoriaTFR()
    {
      Id = -2,
      JogadorF = true,
      Resposta0 = 0
    });
    
    historia.Add(new HistoriaTFR()
    {
      Id = -3,
      JogadorF = true,
      Resposta0 = 0
    });

    Iniciar();
  }

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
      ButaofunfaProximo.IsVisible = false;
      Butaofunfa1.IsVisible = true;
      Butaofunfa2.IsVisible = true;
      Butaofunfa3.IsVisible = true;

      Butaofunfa1.Text = historiaatual.TextoR0;
      Butaofunfa2.Text = historiaatual.TextoR1;
      Butaofunfa3.Text = historiaatual.TextoR2;
    }
    else
    {
      ButaofunfaProximo.IsVisible = true;
      Butaofunfa1.IsVisible = false;
      Butaofunfa2.IsVisible = false;
      Butaofunfa3.IsVisible = false;
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

  void ClicaNoProximo(object sender, EventArgs args)
  {
    var proximoId = historiaatual.Id + 1;
    TrocaHistoryStepAtual(proximoId);
  }

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
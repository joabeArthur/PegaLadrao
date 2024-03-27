
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
      Texto = "*(você) boa noite, oque você viu me fale                                *(testemunha) eu vi um cara um pouco maior que eu brigando com uma mulher eles estavam gritando um com o outro estavam falando sobre pacotes",
      TextoR0 = "(você) oque estavão falando mais especificamente?",
 

      Resposta0 = 5,
      Aresposta=true
    });

    historia.Add(new HistoriaTFR()
    {
      Id = 5,
      Texto = "*(testemunha) parecia que o homem ficou irritado com a mulher porque ela deu os pacotes pra pessoa errada",
      TextoR0 = "*(você) você consegiu ver como era esse pacote?",
 

      Resposta0 = 6,

      Aresposta=true
    });

    historia.Add(new HistoriaTFR()
    {
      Id = 6,
      Texto = "*(testemunha) sim parecia um pó branco",

      TextoR0 = "*(você) você lembra de mais alguma coisa?",
      TextoR1 = "*(você) muito obrigado pela ajuda.",
      TextoR2 = "(dar um soco na testemunha e gritar (MENTIROSO!!!))",
 

      Resposta0 = 7,
      Resposta1 = -100,
      Resposta2 = 8,

      Aresposta=true
    });

    historia.Add(new HistoriaTFR()
    {
      Id = 7,
      Texto = "*(testemunha) não lembro de mais nada",

      TextoR0 = "*(você) muito obrigado pela ajuda",
      TextoR1 = "(dar um soco na testemunha e gritar (mentirosa!!!))",
 

      Resposta0 = -100,
      Resposta1 = 8,

      Aresposta=true
    });
    //======================================caminho pra do mal===================================================\\

    historia.Add(new HistoriaTFR()
    {
      Id = 8,
      Texto = "*(testemunha) AJUDA!!! AJUDA!!! AJUDA!!!",

      TextoR0 = "(colocar a arma na cara dele e falar (eu vou te matar se você não falar a verdade))",
      TextoR1 = "(pedir desculpas)",
 

      Resposta0 = 2,

      Aresposta=true
    });

    //======================================caminho pra do bem===================================================\\

    historia.Add(new HistoriaTFR()
    {
      Id = -100,
      Texto = "(você segue para a delegacia)",

      TextoR0 = "*(você) o quero falar com o criminoso",//não tenho certeza se é essa palavra
 

      Resposta0 = 2,

      Aresposta=true
    });

    //=============================================perdeu============================================\\

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
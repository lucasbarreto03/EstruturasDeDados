LISTAS ENCADEADAS

Uma lista encadeada é composta por uma quantidade indefinida de elementos organizados de forma não sequencial na memória, ou seja, distribuídos sem uma ordem física linear. Esses elementos são chamados de nós. Para estruturar a lista de maneira que ela funcione como um conjunto linear, cada nó possui dois componentes principais: um valor (que pode ser de qualquer tipo) e uma referência (ou endereço) que aponta para o próximo nó da sequência. O último nó é diferenciado dos demais para indicar que ele não está conectado a nenhum outro.

As listas encadeadas podem ser classificadas em quatro tipos principais:


Encadeada simples: cada nó armazena um único endereço, que aponta para o próximo nó na sequência.

Duplamente encadeada: cada nó contém dois endereços, um que aponta para o nó anterior e outro para o nó seguinte.

Ordenadas: A ordem sequencial da lista reflete a sequência dos elementos. Portanto, quando um novo item é inserido, ele deve ser posicionado de forma que a ordem original da lista seja preservada. Uma lista ordenada pode ser implementada com encadeamento simples ou duplo, mas o princípio de ordenação permanece o mesmo.

Circulares: O último item da lista está conectado ao primeiro, formando um ciclo. Assim, a lista pode ser percorrida de forma contínua, tanto da direita para a esquerda quanto da esquerda para a direita.


Considerando que a alocação de memória fixa por meio de vetores não é tão eficiente, optaremos nesta unidade por alocação dinâmica de memória e implementaremos a lista usando encadeamento simples.

O gerenciamento dos elementos em uma lista é realizado através de operações que desempenham as seguintes funções:

Inicialização ou criação, com declaração dos nós;
Inserção de elementos na lista;
Remoção de elementos da lista;
Pesquisa de elementos na lista.
Agora que você já compreende o conceito de lista encadeada simples, vamos passar para a implementação das operações. A seguir, será apresentada a lógica de cada uma dessas operações em C#.

Um nó será representado em C# por uma classe chamada Node, que deve conter um valor (neste caso, um objeto genérico denominado item) e a variável que apontará para o próximo elemento da lista (denominada prox, do tipo Node), conforme apresentado no código abaixo.

class Node
{
    private Object item;
    private Node prox;

    Node(Object item)
    {
        this.item = item;
        prox = null;
    }
}

Note que, no construtor, o atributo prox é inicializado com null, pois, quando um elemento é inserido na lista, ele pode ser o último da sequência e, nesse caso, não terá um próximo elemento.

Os programas desenvolvidos em C# podem ser reutilizados, permitindo que a classe Node seja utilizada em diferentes programas que necessitem de um nó de encadeamento simples, como é o caso de estruturas como pilhas e filas.

Inserção de elementos em uma lista
Agora que você já entende a estrutura do nó, podemos adicionar novos elementos no início, no final ou em uma posição específica da lista. Na lógica apresentada a seguir, temos uma classe chamada ListaSimples, que contém os atributos do tipo Node chamados primeiro e segundo, que representam respectivamente o primeiro e o último nó da lista. O último nó aponta para null, indicando o final da lista. Essa classe possui três métodos de inserção de elementos: um que insere um nó no início da lista (insereInicio), outro que insere um nó em uma posição específica (inserePosicao), e um terceiro que insere um nó no final da lista (insereFim). Além disso, há um método que retorna a quantidade de elementos na lista (contaNos).

Para que essas operações sejam realizadas corretamente no início ou no final da lista, é necessário conhecer o primeiro e o último nó, ou seja, o nó cabeça, que armazena o primeiro elemento da lista, e o nó cauda, que guarda o último elemento da lista.

public object primeiro { get; private set; }
public object ultimo { get; private set; } 

class ListaSimples
{
    private Node primeiro, ultimo;
    private int qtdeNos;

    ListaSimples()
    {
        primeiro.setProx(null); 
        ultimo.setProx(null);
    }
    void insereFim (Node novo)
    { 
        novo.setProx(null);
        if (this.primeiro==null)
            this.primeiro = novo;
        if (this.ultimo != null)
            this.ultimo.setProx(novo);
        this.ultimo = novo;        
    }
    void insereInicio (Node novo)
    {
        if (this.primeiro != null)
            novo.setProx(novo);
        else 
        { 
            if (this.primeiro == null)
                this.primeiro = novo;
            this.ultimo = novo 
        }

    }
    void inserePosicao (Node novo, int pos)
    {
          Node aux = primeiro;
          int qtde = contaNos();
          int pos_aux;
          if(pos == 0)
          {
              novo.setProx(primeiro);
              if (primeiro == ultimo)
              {
                  ultimo = novo; 
              }
              primeiro = novo;
          }
          else 
          {
              if(pos <= qtde)
              {
                  pos_aux = 1;
                  while(aux != null && pos_aux < pos)
                  {
                      aux = aux.getProx();
                      pos_aux++;
                  }
                  novo.setProx(aux.getProx());
                  aux.setProx(novo);                     
              }
              else
              {
                  if(pos > qtde)
                  {
                      ultimo.setProx(novo);
                      ultimo = novo;
                  }
              }
          }
    }
    public int contaNos()
    {
        Node aux = primeiro;
        int tam = 0;
        while(aux != null)
        {
            tam++;
            aux = aux.getProx();
        }
        return tam;
    }
}


Exclusão de elemento da lista
Na operação de exclusão, vamos apresentar apenas o método correspondente, lembrando que esse e os demais métodos foram desenvolvidos dentro da classe ListaSimples, conforme apresentado no código acima.

O método de exclusão de um elemento da lista (código abaixo) recebe como parâmetro o objeto genérico item, que deve ser removido da lista. Quando o item é encontrado, é necessário que a referência a ele seja eliminada e que a lista passe a apontar para o próximo elemento, ou seja, o próximo nó após o elemento excluído.

void excluiNo (Object item)
{
    Node aux = primeiro;
    while (aux != null && !aux.getItem().equals(item))
    {
        aux = aux.getProx();
    }
    aux.setProx(aux.getProx().getProx());
    if (ultimo == aux.getProx())
        ultimo = aux;
}


Busca de elemento em uma lista
O método de busca de um elemento na lista (código abaixo) recebe como parâmetro o objeto genérico item, que deverá ser procurado na lista. Para realizar essa busca, a lista é percorrida utilizando a estrutura de repetição while. Em cada iteração, o valor do campo item do nó atual é comparado com o item passado como parâmetro. Se houver uma correspondência, o nó é retornado. Caso contrário, se o item não for encontrado, o método retorna null.

Node buscaNo(Object item)
{
    int i = 0;
    Node aux = primeiro;
    while (aux != null)
    {
        if (aux.getItem() == item)
        {
            return aux;
        }
        aux = aux.getProx();
    }
    return null;
}

Com esses métodos, você poderá usar a estrutura de dados lista para resolver problemas na área de jogos, sempre que a lógica apresentada aqui for aplicável. Vale destacar que, uma vez que você compreenda o funcionamento da lista encadeada simples, outros tipos de listas também podem ser implementados.
  

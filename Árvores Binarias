Árvores

As estruturas apresentadas até agora são chamadas de lineares. Embora a importância dessas estruturas seja inegável, elas não são ideais para representar dados que precisam ser organizados de forma hierárquica. A estrutura que preenche essa necessidade é a árvore.

Uma árvore é uma estrutura bidimensional, não linear, que possui características especiais e permite a realização de várias operações em conjuntos dinâmicos, como consulta, inserção, remoção, entre outras.

As características de uma árvore são:

Nó raiz: É o nó no topo da árvore, do qual os demais nós descendem. Representa o primeiro nó da árvore.
Nó interior: É um nó localizado no interior da árvore, que possui descendentes.
Nó terminal: É o nó que não possui descendentes.
Trajetória: Refere-se ao número de nós que precisam ser percorridos até alcançar um nó específico.
Grau do nó: Indica o número de nós descendentes de um nó, ou seja, o número de subárvores que ele possui.
Grau da árvore: Representa o número máximo de subárvores de um nó.
Altura da árvore: Refere-se ao número máximo de níveis dos nós na árvore.
As árvores binárias podem ser usadas para o armazenamento temporário de conjuntos de elementos e podem ser implementadas com alocação dinâmica de memória, utilizando listas duplamente encadeadas. Quanto ao tipo de árvore, elas podem ser generalizadas ou binárias. Nas árvores binárias, cada nó pode ter no máximo dois filhos. Nesta unidade, abordaremos apenas as árvores binárias.

Uma árvore binária pode ser nula e, assim como qualquer árvore, possui um elemento denominado raiz, com os demais elementos sendo particionados em T e Tz, que são estruturas disjuntas de árvores binárias. A subárvore à esquerda é chamada de I, e a à direita é chamada de T?

Nesse tipo de árvore, existe uma particularidade em relação à posição dos nós. Os nós à direita sempre possuem um valor superior ao do nó pai, enquanto os nós à esquerda sempre possuem um valor inferior ao do nó pai.

Para a manipulação de árvores, há uma grande similaridade com os nós utilizados na manipulação de listas. Por isso, utilizaremos os mesmos princípios e criaremos uma classe chamada BTreeNo (como mostrado no código abaixo), que implementa o nó da árvore e contém os atributos item (do tipo int), permitindo manipular números inteiros, o que facilita o entendimento da lógica. Vale lembrar que a árvore pode manipular qualquer tipo de dado. Além disso, a classe possui os atributos esq e dir, ambos do tipo BTreeNo. A cada novo nó inserido na árvore, será criada uma instância da classe BTreeNo, ou seja, um novo objeto nó.

class BTreeNo
{
    private int item;
    private BTreeNo esq;
    private BTreeNo dir;

    BTreeNo(int valor)
    {
        this.valor = valor;
    }
    public void setValor(int valor)
    public void setEsq(BTreeNo esq)
    public void setDir(BTreeNo dir)
    public int getValor()
    public BTreeNo getEsq()
    public BTreeNo getDir()
}

Após definir a estrutura do nó da árvore, o próximo passo é criar a classe árvore, que será instanciada sempre que uma nova árvore for criada. Essa classe conterá os métodos responsáveis por possibilitar as operações de inserção e exclusão de nós. Os métodos de inserção estão apresentados no código abaixo.

class Btree
{
    private BTreeNo raiz;

    private BTreeNo inserir(BTreeNo arvore, int novo)
    {
        BTreeNo aux = null
        if (arvore == null)
        {
            aux.setValor(novo);
            return aux;
        }
        else if (novo < arvore.getValor())
        {
            arvore.setEsq(inserir(arvore.getEsq(), novo));
        }
        else
        {
            arvore.setDir(inserir(arvore.getDir(), novo));
        }
        return arvore;
    }
    public void inserirNo(int novo)
    {
        raiz = inserir(raiz, novo);
    }
}

Inserir nó em uma árvore
De acordo com a lógica apresentada, o objeto BTreeNo será instanciado toda vez que um novo nó for inserido na árvore. O método inserirNo é responsável por receber o valor a ser inserido e, em seguida, chama o método inserir, que recebe como parâmetros um valor do tipo BTreeNo (denominado nó no código) e um valor inteiro. Este método percorre recursivamente a árvore a partir da raiz, buscando uma posição de referência nula para inserir o novo elemento.

Quando a estrutura de dados está vazia, o método insere o novo elemento na raiz; quando já existem elementos na árvore, o método verifica se o valor a ser inserido é maior ou menor que o nó atual. Se o valor for menor, o nó será inserido à esquerda; caso contrário, será inserido à direita. A recursividade é utilizada para percorrer os nós até encontrar um nó vazio (null), permitindo a inserção de um novo nó.

Exibir nós de uma árvore
Para exibir os valores da árvore, apresentamos o método correspondente, lembrando que este e os demais métodos foram desenvolvidos dentro da classe BTree, conforme mostrado no código abaixo.

public void exibirEsquerdo(BTreeNo arv)
{
    if (arv != null)
    {
        exibirEsquerdo(arv.getEsq());
        Console.WriteLine(arv.getValor());
    }
}
public void exibirDireito(BTreeNo arv)
{
    if (arv != null)
    {
        Console.WriteLine(arv.getValor())
    }
}
public void exibirRaiz()
{
    Console.WriteLine("Raiz: " + raiz.getValor());
}
public void exibirNoEsq()
{
    exibirEsquerdo(raiz);
}
public void exibirNoDir()
{
    exibirDireito(raiz);
}
public void exibirNoDir()
{
    exibirDireito(raiz);
}

Assim como o método inserirNo, os métodos exibirNoEsq e exibirNoDir não recebem parâmetros e chamam os métodos exibirEsquerdo ou exibirDireito, passando como parâmetro o nó denominado raiz. Os métodos exibirEsquerdo e exibirDireito recebem como parâmetro um objeto do tipo BTreeNo, que é passado pelos métodos exibirNoEsq ou exibirNoDir. Através de chamadas recursivas, esses métodos buscam os nós à esquerda ou à direita da árvore, até que um nó nulo seja encontrado. Esse percurso garante que os valores sejam impressos sempre na ordem ascendente.

Excluir nó de uma árvore
A exclusão de um nó em uma árvore requer uma lógica mais complexa, pois é necessário ajustar as referências ao nó excluído e aos seus filhos.

A lógica apresentada a seguir mostra o método de exclusão, que recebe como parâmetro o valor do elemento a ser excluído.

public void excluirNo(int valor)
{
    BTreeNo aux=raiz, pai=null, filho=raiz,temp;
    while (aux != null && aux.getValor() != item)
    {
        pai = aux;
        if (item < aux.getValor())
          aux = aux.getEsq();
        else
          aux = aux.getDir();
    }
    }else if (aux.getDir() == null)
    {
        if (pai.getEsq() == aux)
            pai.setEsq(aux.getEsq());
        else
            pai.setDir(aux.getEsq());
    }else if (aux.getEsq() == null)
    {
        if (pai.getEsq() == aux)
            pai.setEsq(aux.getDir());
        else
            pai.setDir(aux.getDir());
    }
    if (aux == null)
      Console.WriteLine("Valor não encontrado");
    if (pai == null)
    {
        if (aux.getDir() == null)
            raiz = aux.getEsq();
        else if (aux.getEsq() == null)
            raiz = aux.getDir();
        else
        {
            for (temp = aux, filho = aux.getEsq(); filho.getDir() != null; 
                 temp = filho, filho = filho.getDir());
            if (filho != aux.getEsq())
            {
                temp.setDir(filho.getEsq());
                filho.setEsq(aux.getEsq());
            }
            filho.setDir(aux.getDir());
            raiz = filho;
        }
    else
    {
        for (temp = aux, filho = aux.getEsq(); filho.getDir() != null; 
             temp = filho, filho = filho.getDir());
        if (filho != aux.getEsq())
        {
            temp.setDir(filho.getEsq());
            filho.setEsq(aux.getEsq());
        }
        filho.setDir(aux.getDir());
        if(pai.getEsq() == aux)
            pai.setEsq(filho);
        else
            pai.setDir(filho);
    }
  }

Primeiramente, realiza-se uma busca nos diversos nós da árvore, comparando o valor passado como parâmetro com o valor do nó. Após isso, são tratados os diferentes cenários possíveis, como por exemplo: percorrer toda a árvore e não encontrar o valor; o nó a ser excluído ser o nó raiz; nós sem filhos à direita ou à esquerda. Para os nós que possuem filhos tanto à esquerda quanto à direita, é realizada uma busca pelo elemento mais à direita do ramo esquerdo da árvore (o maior valor em relação à raiz que será excluída), e esse elemento é trocado pela raiz, com as referências sendo atualizadas.

Caso o elemento pai não seja nulo, isso significa que o nó a ser excluído não é o nó raiz. Se o nó a ser excluído não tiver filhos à direita, a referência do nó pai será trocada pela referência do nó a ser excluído (a mesma lógica é aplicada caso o nó não tenha filhos à esquerda). No caso do nó a ser excluído possuir filhos à esquerda e à direita, aplica-se a mesma lógica de exclusão do nó raiz, mas as referências do pai do nó a ser excluído devem ser ajustadas.

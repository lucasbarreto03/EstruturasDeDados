Lista Ordenada

Em uma lista ordenada, os elementos mantêm a ordem conforme um critério preestabelecido após as operações de inserção ou exclusão. Ou seja, os nós podem ser inseridos ou removidos de maneira que a ordem da lista seja preservada, sem a necessidade de realocar os demais elementos. De acordo com a definição de lista ordenada, nada impede a presença de elementos repetidos, e como as operações de busca e exclusão lidam com esses elementos depende da lógica do problema em questão.

As operações de criação, remoção e busca podem ser as mesmas usadas em listas simples encadeadas. A principal diferença estará nos métodos de inserção. Na lista ordenada, o novo elemento será inserido antes do nó cujo valor é maior do que o valor a ser inserido. Assim, o nó com o valor menor apontará para o novo nó, e este, por sua vez, apontará para o nó que contém o maior valor (no caso de ordenação crescente). Em uma ordenação decrescente, a lógica será invertida.

Para que você compreenda a prática da lógica de uma lista ordenada, apresentamos o método de inserção de um nó em uma lista simples encadeada. Nesta implementação, consideramos que a lista manipula números inteiros como conteúdo.

void insereNoOrdenado(Node novo)
{
    Node aux;
    //Verificando se a lista está vazia
    if (primeiro == null || contaNos() == 0)
    {
        novo.setProx(primeiro);
        primeiro = novo;
    }
    else
    {
        aux = primeiro;
        int valorNovo = Convert.ToInt32(novo.getItem());
        int valorAux = Convert.ToInt32(aux.getItem());
        while (aux.getProx() != null && valorNovo > valorAux)
        {
            aux = aux.getProx();
        }
        novo.setProx(aux.getProx());
        aux.setProx(novo);
    }
}



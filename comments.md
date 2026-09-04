-- A FAZERES INICIAIS DO GRUPO --

Afonso
-> [X] Criar modelo de arquivos para repositório
-> [X] Criar o backend inicial para futura conexão de Endpoints
-> [ ] Modelar banco de dados base

Fabricio
-> [X] Criar repositório local para o projeto em sua máquina e dar um pull
-> [X] Selecionar API externa que será usada no projeto
-> [X] Simular testes de ENDPOINTS

Eduardo
-> [X] Criar repositório local para o projeto em sua máquina e dar um pull
-> [ ] Criar esqueleto da página inicial do projeto HTML + CSS (se baseie no modelo basico da página do CRIS)

DOCUMENTAÇÃO DO USO DO Tormenta20Repository
ao usar na documentação no back-end apenas escrever Tormenta20.classe por exeplo que ele vai puxar os respectivos dados;

caso for usado no front ai você ira chamar os seguintes protocolos http;

Classes:
"/classes" - Retorna todas as Classes;
"/classes/:classe" - Retorna a classe do parâmetro. Ex.: classes/barbaro;
"/classes/:classe/habilidades" - Retorna as Habilidades da classe do parâmetro. Ex.: classes/arcanista/Caminhos da Magia;
"/classes/:classe/tabelanivel" - Retorna as Tabela de Nível da classe do parâmetro. Ex.: classes/barbaro/tabelanivel;
"/classes/:classe/proeficiencias/" - Retorna as Proeficiências da classe do parâmetro. Ex.: classes/barbaro/proeficiencias;
"/classes/:classe/pericias/" - Retorna as Perícias da classe do parâmetro. Ex.: classes/barbaro/pericias;

Divindades:
"/divindades" - Retorna todas as Divindades;
"/divindades/:divindade" - Retorna a divindade do parâmetro. Ex.: divindade/valkaria;

Habilidades:
"/habilidades" - Retorna todas as Habilidades;
"/habilidades/:habilidade" - Retorna a habilidade do parâmetro. Ex.: habilidade/alta_arcana;

Raças:
"/racas" - Retorna todas as Raças;
"/racas/:raca" - Retorna a raça do parâmetro. Ex.: racas/humano;

Perícias:
"/pericias" - Retorna todas as Perícias;
"/pericias/:pericia" - Retorna a perícia do parâmetro. Ex.: pericias/atletismo; o retorno é um pouco diferente

Atributos:
"/atributos" - Retorna todas os atributos;

Talentos:
"/talentos" - Retorna todos os talentos;
"/talentos/:talento" - Retorna o talento do parâmetro. Ex.: /talentos/acuidade_com_arma

Raças:
"/racas" - Retorna todos as raças;
"/racas/:raca" - Retorna as raças do parâmetro. Ex.: /racas/humano

Origens:
"/origens" - Retorna todos as origens;
"/origens/:origen" - Retorna as origens do parâmetro. Ex.: /origens/humano

Magias:
"/magias" - Retorna todos as magias;
"/magias/:magia" - Retorna as origens do parâmetro. Ex.: /magias/abencoar_alimentos

AGORA PARA O USO DA API DE DnD
para o seu consumo no back-end você irá chamar o DnDRepository sendo obrigatório seu método ser assíncrono pois quem chama a api é logo vc precisa ser tbm(ditadura krl),
para você consumir algo é só chamar exemplo DnDRepository.ObterTodosPorCategoriaAsync("monsters"); ou DnDRepository.ObterPorCategoriaENomeAsync("monsters", nome); caso você queira
algo por nome.

DENTRE AS REQUISIÇÕES POSSÍVEIS:

ability-scores
classes
conditions
damage-types
equipment-categories
equipment
features
languages
magic-schools
monsters
proficiencies
races
skills
spells
subclasses
subraces
traits
weapon-properties
CASO ALGO NÃO FUNCIONAR NÃO ME LIGUE BB
// A porta (ex: 5239) deve ser a MESMA onde a sua API está rodando no terminal
const API_URL = "http://localhost:5239/api/Campanha"; 

async function carregarCampanhas() {
    try {
        // Envia a requisição GET para o C#
        const resposta = await fetch(API_URL);
        
        if (!resposta.ok) {
            throw new Error(`Erro na requisição: ${resposta.status}`);
        }

        // Converte a resposta recebida em formato JSON
        const dados = await resposta.json();
        
        console.log("Dados recebidos da API:", dados);

        // Exemplo: Coloca o resultado formatado na tela
        const divResultado = document.getElementById("resultado");
        divResultado.innerHTML = `<pre>${JSON.stringify(dados, null, 2)}</pre>`;
        
    } catch (erro) {
        console.error("Falha ao conectar com o backend:", erro);
        alert("Não foi possível conectar com o servidor C#.");
    }
}
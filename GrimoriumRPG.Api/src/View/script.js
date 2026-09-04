// A porta (ex: 5239) deve ser a MESMA onde a sua API está rodando no terminal
const API_URL = "http://localhost:5239/api/Campanha";

function buscaLogin(){
    // Intercepta o envio do formulário para simular a busca no banco de dados
    document.getElementById('loginForm').addEventListener('submit', function(event) {
        event.preventDefault(); // Impede o recarregamento da página
        
        const submitBtn = document.getElementById('submitBtn');
        const loadingMsg = document.getElementById('loadingMessage');
        
        // Oculta o botão e mostra a mensagem de carregamento
        submitBtn.style.display = 'none';
        loadingMsg.style.display = 'block';

        // Simula o tempo de resposta do Banco de Dados (1.5 segundos)
        setTimeout(() => {
            const user = document.getElementById('username').value;
            
            /* 
             * AQUI ENTRARIA O CÓDIGO DE BACKEND REAL (Fetch API / Axios).
             * Exemplo:
             * fetch('/api/login', { method: 'POST', body: JSON.stringify({ user, password }) })
             * .then(response => ...)
             */
            
            alert(`Busca no banco concluída. Bem-vindo de volta, ${user}! \n(Redirecionando para as mesas...)`);
            
            // Simula o redirecionamento para o sistema principal após o login
            // window.location.href = 'dashboard.html'; 
            
            // Restaura a tela para testes
            submitBtn.style.display = 'block';
            loadingMsg.style.display = 'none';
            this.reset(); // Limpa os campos
            
        }, 1500);
    });
}
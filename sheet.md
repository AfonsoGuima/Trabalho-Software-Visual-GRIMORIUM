<!-- <header class="topo">
        <div class="topo__marca">
            <svg class="topo__emblema" viewBox="0 0 48 48" aria-hidden="true">
                <circle cx="24" cy="24" r="21" />
                <path d="M24 6 L42 38 H6 Z" />
                <circle cx="24" cy="27" r="6" />
            </svg>
            <div>
                <h1 class="topo__titulo">GRIMORIUM</h1>
                <p class="topo__sub">Sistema de Fichas &middot; Ordem Paranormal</p>
            </div>
        </div>

        <nav class="topo__nav">
            <a href="index.html" class="is-ativa">Nova Ficha</a>
            <a href="#">Campanhas</a>
            <a href="#">Sobre</a>
        </nav>
    </header>

  <main class="pagina">
    <form class="ficha" autocomplete="off">

      <div class="ficha__cabecalho">
        <h2>Criar Ficha de Ordem</h2>
        <p>Preenche os dados do agente. O layout inicial cobre identidade, atributos e status &mdash; as restantes secções entram nas próximas iterações.</p>
      </div>

      <section class="bloco">
        <h3 class="bloco__titulo">Identidade</h3>
        <div class="grelha grelha--identidade">
          <label class="campo campo--largo">
            <span>Nome do personagem</span>
            <input type="text" name="nome" placeholder="Ex.: Ana Ferreira" />
          </label>
          <label class="campo">
            <span>Jogador</span>
            <input type="text" name="jogador" />
          </label>
          <label class="campo">
            <span>Origem</span>
            <input type="text" name="origem" placeholder="Ex.: Militar" />
          </label>
          <label class="campo">
            <span>Classe</span>
            <select name="classe">
              <option value="">—</option>
              <option>Combatente</option>
              <option>Especialista</option>
              <option>Ocultista</option>
            </select>
          </label>
          <label class="campo">
            <span>Trilha</span>
            <input type="text" name="trilha" placeholder="Ex.: Aniquilador" />
          </label>
          <label class="campo campo--nex">
            <span>NEX</span>
            <div class="nex">
              <input type="number" name="nex" min="0" max="100" step="5" value="5" />
              <span class="nex__pct">%</span>
            </div>
          </label>
          <label class="campo">
            <span>Patente</span>
            <select name="patente">
              <option>Recruta</option>
              <option>Operador</option>
              <option>Agente Especial</option>
              <option>Oficial de Operações</option>
              <option>Agente de Elite</option>
            </select>
          </label>
        </div>
      </section>

      <section class="bloco">
        <h3 class="bloco__titulo">Atributos</h3>
        <div class="atributos">
          <div class="atributo">
            <input type="number" class="atributo__valor" value="1" min="0" max="5" aria-label="Agilidade" />
            <span class="atributo__nome">AGI</span>
            <span class="atributo__desc">Agilidade</span>
          </div>
          <div class="atributo">
            <input type="number" class="atributo__valor" value="1" min="0" max="5" aria-label="Força" />
            <span class="atributo__nome">FOR</span>
            <span class="atributo__desc">Força</span>
          </div>
          <div class="atributo">
            <input type="number" class="atributo__valor" value="1" min="0" max="5" aria-label="Intelecto" />
            <span class="atributo__nome">INT</span>
            <span class="atributo__desc">Intelecto</span>
          </div>
          <div class="atributo">
            <input type="number" class="atributo__valor" value="1" min="0" max="5" aria-label="Presença" />
            <span class="atributo__nome">PRE</span>
            <span class="atributo__desc">Presença</span>
          </div>
          <div class="atributo">
            <input type="number" class="atributo__valor" value="1" min="0" max="5" aria-label="Vigor" />
            <span class="atributo__nome">VIG</span>
            <span class="atributo__desc">Vigor</span>
          </div>
        </div>
      </section>

      <section class="bloco">
        <h3 class="bloco__titulo">Status</h3>
        <div class="status">
          <div class="vital vital--pv">
            <span class="vital__rotulo">Pontos de Vida</span>
            <div class="vital__campos">
              <input type="number" placeholder="Atual" aria-label="PV atual" />
              <span class="vital__barra">/</span>
              <input type="number" placeholder="Máx." aria-label="PV máximo" />
            </div>
          </div>
          <div class="vital vital--pe">
            <span class="vital__rotulo">Pontos de Esforço</span>
            <div class="vital__campos">
              <input type="number" placeholder="Atual" aria-label="PE atual" />
              <span class="vital__barra">/</span>
              <input type="number" placeholder="Máx." aria-label="PE máximo" />
            </div>
          </div>
          <div class="vital vital--san">
            <span class="vital__rotulo">Sanidade</span>
            <div class="vital__campos">
              <input type="number" placeholder="Atual" aria-label="Sanidade atual" />
              <span class="vital__barra">/</span>
              <input type="number" placeholder="Máx." aria-label="Sanidade máxima" />
            </div>
          </div>
          <div class="vital vital--defesa">
            <span class="vital__rotulo">Defesa</span>
            <div class="vital__campos">
              <input type="number" placeholder="10" aria-label="Defesa" />
            </div>
          </div>
        </div>

        <div class="grelha grelha--tres">
          <label class="campo">
            <span>Deslocamento</span>
            <input type="text" value="9m" />
          </label>
          <label class="campo">
            <span>Resistência a dano</span>
            <input type="text" placeholder="0" />
          </label>
          <label class="campo">
            <span>Bloqueio / Esquiva</span>
            <input type="text" placeholder="—" />
          </label>
        </div>
      </section>

      <section class="bloco">
        <h3 class="bloco__titulo">Perícias</h3>
        <p class="bloco__nota">Amostra base &mdash; a lista completa das perícias de Ordem Paranormal entra numa próxima iteração.</p>
        <ul class="pericias">
          <li class="pericia">
            <span class="pericia__nome">Luta</span>
            <select class="pericia__treino" aria-label="Treino em Luta">
              <option>Destreinado</option><option>Treinado</option><option>Veterano</option><option>Expert</option>
            </select>
            <input type="number" class="pericia__bonus" placeholder="+0" aria-label="Bónus em Luta" />
          </li>
          <li class="pericia">
            <span class="pericia__nome">Pontaria</span>
            <select class="pericia__treino" aria-label="Treino em Pontaria">
              <option>Destreinado</option><option>Treinado</option><option>Veterano</option><option>Expert</option>
            </select>
            <input type="number" class="pericia__bonus" placeholder="+0" aria-label="Bónus em Pontaria" />
          </li>
          <li class="pericia">
            <span class="pericia__nome">Reflexos</span>
            <select class="pericia__treino" aria-label="Treino em Reflexos">
              <option>Destreinado</option><option>Treinado</option><option>Veterano</option><option>Expert</option>
            </select>
            <input type="number" class="pericia__bonus" placeholder="+0" aria-label="Bónus em Reflexos" />
          </li>
          <li class="pericia">
            <span class="pericia__nome">Fortitude</span>
            <select class="pericia__treino" aria-label="Treino em Fortitude">
              <option>Destreinado</option><option>Treinado</option><option>Veterano</option><option>Expert</option>
            </select>
            <input type="number" class="pericia__bonus" placeholder="+0" aria-label="Bónus em Fortitude" />
          </li>
          <li class="pericia">
            <span class="pericia__nome">Vontade</span>
            <select class="pericia__treino" aria-label="Treino em Vontade">
              <option>Destreinado</option><option>Treinado</option><option>Veterano</option><option>Expert</option>
            </select>
            <input type="number" class="pericia__bonus" placeholder="+0" aria-label="Bónus em Vontade" />
          </li>
          <li class="pericia">
            <span class="pericia__nome">Percepção</span>
            <select class="pericia__treino" aria-label="Treino em Percepção">
              <option>Destreinado</option><option>Treinado</option><option>Veterano</option><option>Expert</option>
            </select>
            <input type="number" class="pericia__bonus" placeholder="+0" aria-label="Bónus em Percepção" />
          </li>
          <li class="pericia">
            <span class="pericia__nome">Investigação</span>
            <select class="pericia__treino" aria-label="Treino em Investigação">
              <option>Destreinado</option><option>Treinado</option><option>Veterano</option><option>Expert</option>
            </select>
            <input type="number" class="pericia__bonus" placeholder="+0" aria-label="Bónus em Investigação" />
          </li>
          <li class="pericia">
            <span class="pericia__nome">Ocultismo</span>
            <select class="pericia__treino" aria-label="Treino em Ocultismo">
              <option>Destreinado</option><option>Treinado</option><option>Veterano</option><option>Expert</option>
            </select>
            <input type="number" class="pericia__bonus" placeholder="+0" aria-label="Bónus em Ocultismo" />
          </li>
        </ul>
      </section>

      <section class="bloco">
        <h3 class="bloco__titulo">Anotações</h3>
        <div class="grelha grelha--dois">
          <label class="campo">
            <span>História</span>
            <textarea rows="5" placeholder="Passado do agente, ligação à Ordem..."></textarea>
          </label>
          <label class="campo">
            <span>Personalidade / Objetivos</span>
            <textarea rows="5"></textarea>
          </label>
        </div>
      </section>

      <div class="ficha__acoes">
        <button type="reset" class="btn btn--fantasma">Limpar</button>
        <button type="button" class="btn btn--principal">Guardar ficha</button>
      </div>

    </form>
  </main>

  <footer class="rodape">
    <p>GRIMORIUM &middot; Trabalho de Software Visual &middot; Projeto de fãs baseado em Ordem Paranormal RPG</p>
  </footer> -->
# Unity 5 Car Tutorial

## Controle de Carro Realista em Unity 5 (e Superiores!)

Um projeto prático e abrangente que demonstra a implementação de um sistema de rigging e controle de carro realista usando o WheelCollider da Unity. Perfeito para desenvolvedores que desejam entender e criar sua própria física de veículos, seja para jogos de corrida, simulação ou mundos abertos.

✨ Por que usar este Tutorial/Projeto?

    Física Realista: Implementa torque, aceleração, frenagem e direção baseados em física, utilizando o Rigidbody e WheelCollider da Unity.

    Código Limpo: Scripts organizados em C# para fácil compreensão e modificação.

    Pronto para Uso: Contém o carro modelo, scripts e a cena de demonstração prontos para serem explorados.

    Base Sólida: Ideal como ponto de partida para aprimorar a suspensão, derrapagem e outros recursos avançados de veículos.

🛠️ Tecnologias e Requisitos

    Engine: Unity (Originalmente desenvolvido para Unity 5, mas compatível com versões recentes - testes de compatibilidade em versões mais novas são bem-vindos!).

    Linguagem: C#.

## Requisitos

Para clonar e executar este projeto:

    Ter o Unity Hub e uma versão do Unity (Recomendado: 2019.x LTS ou mais recente) instalada.

    Um ambiente de desenvolvimento de código (ex: Visual Studio, VS Code).

## 🚀 Como Começar

1. Clonar o Repositório

Abra seu terminal ou use o GitHub Desktop:
Bash

git clone https://github.com/daybson/Unity5CarTutorial.git

2. Abrir no Unity

    Abra o Unity Hub.

    Clique em "Adicionar" e selecione a pasta Unity5CarTutorial que você acabou de clonar.

    Abra o projeto na versão do Unity instalada.

3. Executar a Demonstração

    No Editor da Unity, navegue até a pasta Assets/Scenes/.

    Abra a cena DemoScene (ou nome da cena principal, se diferente).

    Pressione o botão Play e comece a dirigir!

## 🎮 Controles

Ação	Tecla
Acelerar	↑ (Seta para Cima) / W
Frear / Ré	↓ (Seta para Baixo) / S
Direção (Esquerda)	← (Seta para Esquerda) / A
Direção (Direita)	→ (Seta para Direita) / D
Freio de Mão	Espaço

## 💡 Estrutura do Código Principal

O coração do sistema de controle está no script CarControl.cs (ou nome do script principal).

    CarControl.cs: Lida com a entrada do usuário, aplica o torque nos WheelColliders e o ângulo de direção nas rodas dianteiras.

    WheelCollider Setup: O script interage diretamente com os componentes WheelCollider configurados no carro, que simulam a suspensão e a física do pneu.

    Modelo de Carro: O objeto de carro principal contém o Rigidbody e os scripts de controle. As rodas visuais são rotacionadas com base nos dados de rotação dos WheelColliders.

## 🤝 Contribuições

Este projeto foi criado como um tutorial e ponto de partida. Contribuições, sejam elas correções de bugs, melhorias de desempenho, ou atualizações para versões mais recentes do Unity, são muito bem-vindas!

    Faça um Fork do projeto.

    Crie uma Branch para sua feature (git checkout -b feature/NovaFisica).

    Commit suas alterações (git commit -m 'feat: Adiciona nova física de suspensão').

    Faça o Push para a Branch (git push origin feature/NovaFisica).

    Abra um Pull Request.

## 📄 Licença

Este projeto está sob a Licença MIT. Veja o arquivo LICENSE para mais detalhes.

## 👤 Autor

Daybson - GitHub: @daybson

    Gostou do projeto? Dê uma estrela (⭐️) no repositório! Isso me incentiva a criar e compartilhar mais tutoriais e recursos.


![image](https://github.com/user-attachments/assets/86dad34c-af0f-452e-affa-b917034c578e)

![image](https://github.com/user-attachments/assets/d35f0458-f60e-4667-a118-c50e12f1bac5)

![image](https://github.com/user-attachments/assets/0c04344d-91e7-4e24-8d45-4f6b7c42e734)

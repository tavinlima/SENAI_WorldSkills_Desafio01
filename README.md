# SENAI_WorldSkills_Desafio01
* Repositório com o primeiro desafio do SENAI para a World Skills
* Os códigos feitos aqui são baseados nas aulas do treinamento e principalmente neles.

## Passo a Passo para utilização
- O primeiro passo é clonar esse repositório na sua máquina. Dê um git clone em uma pasta do seu computador e puxe todo o conteúdo do repositório;
![Captura de tela 2022-04-09 103123](https://user-images.githubusercontent.com/82414372/162576309-8391b542-9dd4-46fd-81df-42dd8bf0c393.png)
![image](https://user-images.githubusercontent.com/82414372/139128823-ff065a72-ef85-4fa0-9a44-ce42be7597cd.png)
![image](https://user-images.githubusercontent.com/82414372/139128835-9f3437e5-ddf4-4327-b7f7-596120011dec.png)

- Abra o ssms no seu computador, troque a 'Authentication' por Windows Authentication e arraste os scripts localizados na pasta 'DataBase', é o arquivo 'DDL_DML_WSTowers.sql';
- ![image](https://user-images.githubusercontent.com/82414372/162577363-83fa5b94-98a3-4bc4-80f9-bf8375c871db.png)
![image](https://user-images.githubusercontent.com/82414372/162576403-e4029f19-a409-45b0-ace7-4e29292d5062.png)

- Execute (aperte F5) o script para criar o banco na sua máquina, os dados a serem inseridos também estão no script;
- ![image](https://user-images.githubusercontent.com/82414372/162576890-c468761e-1b8c-47ff-b9c3-634f07147231.png)

- Agora dentro da pasta principal, entre na pasta 'API' > WSTowers_webApi > WSTowers_webAPI
![image](https://user-images.githubusercontent.com/82414372/162576940-8c08a8b7-3e3b-4b78-ab8f-d22900bc17d6.png)
![image](https://user-images.githubusercontent.com/82414372/162576952-7e528fb7-17ed-4dec-862c-976bf4b9de58.png)
![image](https://user-images.githubusercontent.com/82414372/162576996-1662654b-0fe4-438b-9a33-4f50702f2f52.png)
![image](https://user-images.githubusercontent.com/82414372/162577003-5df85adb-cc6c-42ba-8d7a-cba0dea5ad92.png)
 
 - E no caminho do projeto, digite 'cmd'
 ![image](https://user-images.githubusercontent.com/82414372/162577187-219b6e64-fa4e-420f-b6b1-5991766692c2.png)
 - Será aberto um terminal, digite 'dotnet run' 
![image](https://user-images.githubusercontent.com/82414372/162577496-2512049e-b01b-4e3d-ab63-2377ee379030.png)
![image](https://user-images.githubusercontent.com/82414372/162577265-c776d629-a271-4834-b884-addd18d9f8f1.png)

ps: Não precisa se preocupar com a string de conexão na API, pois ela está conectada ao 'localhost'

 - Se tudo der certo, uma página do Swagger abrirá e você poderá fazer suas requisições!
 ![image](https://user-images.githubusercontent.com/82414372/162577155-fff0d24a-bc05-4346-82b0-0b106b4c8282.png)

-  Ou, voltando na pasta 'API' > 'Postman', clique em no arquivo e entre pelo 'Postman'
![image](https://user-images.githubusercontent.com/82414372/162577075-8111e84e-3da3-426d-bd9b-de996a5d930b.png)
![image](https://user-images.githubusercontent.com/82414372/162577090-159d1c66-6562-4093-89b8-4629ac955911.png)
![image](https://user-images.githubusercontent.com/82414372/162577102-8e078294-ee6b-4d32-9eaf-ad69cac91c00.png)
![image](https://user-images.githubusercontent.com/82414372/162577172-1950da18-c3ce-4776-aecb-b23346524e3f.png)

# Validation-TOTP-2FA

Este projeto é um estudo de caso que implementa um autenticador com funcionalidades para geração de códigos TOTP (Time-based One-Time Password) e validação desses códigos. O objetivo é demonstrar como criar um sistema que cadastra um usuário e valida a identidade dele por meio de autenticação de dois fatores (2FA), enviando um código de autenticaçao para o e-mail cadastrado e solicitando que o usuário valide esse código.

## Funcionalidades

- **Cadastro de Usuário:** Permite que novos usuários se cadastrem no sistema.
- **Geração de Códigos TOTP:** Gera códigos temporários de uso único com base no tempo.
- **Envio de Códigos de Autorização:** Envia um código TOTP para o e-mail cadastrado do usuário.
- **Validação do Código:** Valida o código enviado pelo usuário para completar o processo de autenticação.

## Tecnologias Utilizadas


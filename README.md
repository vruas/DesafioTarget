# README — Como executar os programas

Este projeto contém **3 programas em C#**:

1. **Programa 1** — Calculadora de Comissão
2. **Programa 2** — Controle de Estoque
3. **Programa 3** — Calculadora de Juros

Os Programas **1 e 2 utilizam arquivos JSON**, por isso é essencial configurar corretamente antes de executar.

---

## ✔ Antes de rodar: habilite “Copiar sempre” nos arquivos JSON

Para evitar `FileNotFoundException`, marque **dados.json** e **estoque.json** para serem copiados para o diretório de saída.

### Como fazer (Visual Studio):

1. Clique no arquivo `dados.json` ou `estoque.json`.
2. Vá em **Propriedades**.
3. Em **Copiar para o diretório de saída**, escolha **Copiar sempre**.

### Alternativa via `.csproj`:

```xml
<ItemGroup>
  <None Include="estoque.json" CopyToOutputDirectory="Always" />
  <None Include="dados.json" CopyToOutputDirectory="Always" />
</ItemGroup>
```

---

## ✔ Como executar

### Via terminal:

```bash
dotnet run --project ./Programa1_Comissao
dotnet run --project ./Programa2_Estoque
dotnet run --project ./Programa3_Juros
```

### Ou executando diretamente o `.exe`:

```
bin/Debug/net8.0/ProgramaX.exe
```

---

## ✔ JSONs utilizados

* **Programa 1** → `dados.json`
* **Programa 2** → `estoque.json`
* **Programa 3** → não utiliza JSON

---

## ✔ Observação final

Após configurar a cópia dos JSONs, todos os programas podem ser executados normalmente sem ajustes adicionais.

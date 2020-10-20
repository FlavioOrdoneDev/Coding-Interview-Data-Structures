/*
    passos
        Tornar a string em um array
        Reverter os caracteres
        Juntar novamente os caracteres
        Retornar o resultado
 */

function reverseString(palavra) {
    return palavra.split("").reverse().join("");
}

/*
    passos
        declarar uma string vazia
        percorrer um loop foreach
        Retornar o resultado
*/

function reverseStringLoop(palavra) {
    let reversed = "";

    for (var item of palavra) {
        reversed = item + reversed;
    }

    return reversed;
}
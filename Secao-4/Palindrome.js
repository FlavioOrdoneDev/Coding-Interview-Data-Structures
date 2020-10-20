/*
    passos
        Tornar a string em um array
        Reverter os caracteres
        Juntar novamente os caracteres
        valida se é verdadeiro ou falso
        Retornar o resultado
 */

function palindrome(palavra) {
    var reversed = palavra.split("").reverse().join("");

    if (reversed === palavra)
        return true;

    return false;
}

function palindromeAlternative(str) {
    return str.split("").every((char, i) => {
        return char === str[str.length - i - 1];
    })
}

/*
    passos
        declarar uma string vazia
        percorrer um loop foreach
        valida se é verdadeiro ou falso
        Retornar o resultado
*/

function palindromeLoop(palavra) {
    let reversed = "";

    for (var item of palavra) {
        reversed = item + reversed;
    }

    if (reversed === palavra)
        return true;

    return false;
}
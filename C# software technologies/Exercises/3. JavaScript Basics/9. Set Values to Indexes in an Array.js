function solve(arr) {
    let number = Number(arr[0]);
    let array = new Array(number).fill(0);

    for(let i = 1; i < arr.length; i++){
        let tokens = arr[i].split(' - ');
        let index = Number(tokens[0]);
        let num = Number(tokens[1]);

        array[index] = num;
    }

    console.log(array.join('\n'));
}

solve([
    '3',
    '0 - 5',
    '1 - 6',
    '2 - 7'
]);

solve([
    '5',
    '0 - 3',
    '3 - -1',
    '4 - 2',

]);
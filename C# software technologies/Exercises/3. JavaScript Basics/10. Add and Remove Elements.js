function solve(input) {
    let array = [];
    for (let line of input) {
        let tokens = line.split(' ');

        let command = tokens[0];

        if(command === 'add'){
            let number = Number(tokens[1]);
            array.push(number);
        }
        else if(command === 'remove'){
            let index = Number(tokens[1]);
            array.splice(index, 1);
        }
    }
    console.log(array.join('\n'));
    // for(let i of array) {
    //     console.log(i);
    // }
}

solve([
    'add 3',
    'add 5',
    'add 7'
]);
function solve(input) {

    let object = {};

    for (let i = 0; i < input.length - 1; i++) {
        let tokens = input[i].split(' ');

        let key = tokens[0];
        let value = tokens[1];

        object[key] = value;
    }

    let lastRow = input[input.length - 1];

    if(lastRow in object){
        console.log(object[lastRow]);
    }
    else{
        console.log("None");
    }
}

solve([
    'key value',
    'key eulav',
    'test tset',
    'key'
]);
let getRandomNumber = function (start, range) {
    let getRandom = Math.floor((Math.random() * range) + start);

    while (getRandom > range) {
        getRandom = Math.floor((Math.random() * range) + start);
    }
    return getRandom;
}
console.log(getRandomNumber(5, 10));
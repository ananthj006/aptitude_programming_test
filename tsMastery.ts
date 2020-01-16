class MathClass {
    @subtract(1)
    @multiply(2)
    addOne(number: number) {
        return number + 1;
    }
}
console.log(new MathClass().addOne(2))

function multiply(value: number) {
    return function (target: any, propertyKey: string, descriptor: PropertyDescriptor) {        
        let descriptorFunc = descriptor.value;
        descriptor.value = function () {
            let obj = descriptorFunc.apply(target, arguments);
            return obj * value;
        };
    };
}

function subtract(value: number) {
    return function (target: any, propertyKey: string, descriptor: PropertyDescriptor) {
        let descriptorFunc = descriptor.value;
        descriptor.value = function () {
            let obj = descriptorFunc.apply(target, arguments);
            return obj - value;
        };
    };
}

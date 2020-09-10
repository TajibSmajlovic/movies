function ConsoleLog(message) {
    console.log(message);
}

function dotnetInstanceInvocator(dotnetHelper) {
    dotnetHelper.invokeMethodAsync("IncrementCount");
}
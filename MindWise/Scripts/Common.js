function ShowSuccess(message) {
    jSuccess(
        message, {
            HorizontalPosition: 'center',
            VerticalPosition: 'bottom',
            TimeShown: 3000,
            ShowOverlay: true
        });
}

function ShowError(message) {
    jError(
        message, {
            HorizontalPosition: 'center',
            VerticalPosition: 'bottom',
            TimeShown: 3000,
            ShowOverlay: true
        });


    return false;
}
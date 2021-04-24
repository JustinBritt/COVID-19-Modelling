function GenerateDataGumel2006(
    days,
    values) {
    let data = [];

    let i = 0;

    for (; i < days.length; i++) {
        data.push(
            {
                x: moment(days[i]),
                y: values[i]
            });
    }

    return data;
}

function GenerateChartGumel2006(
    canvas,
    context_canvas_height,
    context_canvas_width,
    days,
    dayLatentIndividuals,
    dayInfectedIndividuals,
    dayTreatedIndividuals,
    daySusceptibleIndividuals,
    dayVaccinatedIndividuals,
    configuration_options_scales_x_scaleLabel_labelString,
    configuration_options_scales_y_scaleLabel_labelString,
    configuration_options_title_text) {

    const context = document.getElementById(canvas).getContext('2d');
    context.canvas.width = context_canvas_width;
    context.canvas.height = context_canvas_height;

    const color = Chart.helpers.color;

    let dayLatentIndividualsDataset = {
        label: 'Latent Individuals',
        backgroundColor: color(window.chartColors.purple).alpha(0.5).rgbString(),
        borderColor: window.chartColors.purple,
        data: GenerateDataGumel2006(
            days,
            dayLatentIndividuals),
        type: 'line',
        pointRadius: 0,
        fill: false,
        lineTension: 0,
        borderWidth: 2
    };

    let dayInfectedIndividualsDataset = {
        label: 'Infected Individuals',
        backgroundColor: color(window.chartColors.red).alpha(0.5).rgbString(),
        borderColor: window.chartColors.red,
        data: GenerateDataGumel2006(
            days,
            dayInfectedIndividuals),
        type: 'line',
        pointRadius: 0,
        fill: false,
        lineTension: 0,
        borderWidth: 2
    };

    let dayTreatedIndividualsDataset = {
        label: 'Treated Individuals',
        backgroundColor: color(window.chartColors.blue).alpha(0.5).rgbString(),
        borderColor: window.chartColors.blue,
        data: GenerateDataGumel2006(
            days,
            dayTreatedIndividuals),
        type: 'line',
        pointRadius: 0,
        fill: false,
        lineTension: 0,
        borderWidth: 2
    };

    let daySusceptibleIndividualsDataset = {
        label: 'Susceptible Individuals',
        backgroundColor: color(window.chartColors.blue).alpha(0.5).rgbString(),
        borderColor: window.chartColors.blue,
        data: GenerateDataGumel2006(
            days,
            daySusceptibleIndividuals),
        type: 'line',
        pointRadius: 0,
        fill: false,
        lineTension: 0,
        borderWidth: 2
    };

    let dayVaccinatedIndividualsDataset = {
        label: 'Vaccinated Individuals',
        backgroundColor: color(window.chartColors.blue).alpha(0.5).rgbString(),
        borderColor: window.chartColors.blue,
        data: GenerateDataGumel2006(
            days,
            dayVaccinatedIndividuals),
        type: 'line',
        pointRadius: 0,
        fill: false,
        lineTension: 0,
        borderWidth: 2
    };

    const configuration = {
        data: {
            datasets: [
                dayLatentIndividualsDataset,
                dayInfectedIndividualsDataset,
                dayTreatedIndividualsDataset,
                daySusceptibleIndividualsDataset,
                dayVaccinatedIndividualsDataset]
        },
        options: {
            scales: {
                x: {
                    type: 'time',
                    distribution: 'series',
                    scaleLabel: {
                        display: true,
                        labelString: configuration_options_scales_x_scaleLabel_labelString
                    },
                    offset: true,
                    ticks: {
                        major: {
                            enabled: true,
                        },
                        fontStyle: 'bold',
                        source: 'data',
                        autoSkip: true,
                        autoSkipPadding: 75,
                        maxRotation: 0,
                        sampleSize: 200
                    },
                },
                y: {
                    type: 'linear',
                    gridLines: {
                        drawBorder: false
                    },
                    scaleLabel: {
                        display: true,
                        labelString: configuration_options_scales_y_scaleLabel_labelString
                    }
                }
            },
            title: {
                display: true,
                text: configuration_options_title_text
            },
            plugins: {
                tooltip: {
                    callbacks: {
                        label: function (context) {
                            var label = context.dataset.label || '';

                            if (label) {
                                label += ': ';
                            }

                            if (context.parsed.y !== null) {
                                label += parseFloat(context.parsed.y).toFixed(2);
                            }

                            return label;
                        }
                    }
                }
            }
        }
    };

    const chart = new Chart(
        context,
        configuration);
}
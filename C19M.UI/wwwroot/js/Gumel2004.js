function GenerateData(
    days,
    values)
{
    let data = [];

    let i = 0;

    for (; i < days.length; i++)
    {
        data.push(
            {
                x: moment(days[i]),
                y: values[i]
            });
    }

    return data;
}

function GenerateLabels(
    days) {
    let data = [];

    let i = 0;

    for (; i < days.length; i++) {
        data.push(
            {
                x: moment(days[i])
            });
    }

    return data;
}

function GenerateChartGumel(
    canvas,
    context_canvas_height,
    context_canvas_width,
    days,
    dayCumulativeDiseaseInducedDeaths,
    dayAsymptomaticIndividuals,
    daySymptomaticIndividuals,
    dayIsolatedIndividuals,
    dayQuarantinedIndividuals,
    dayRecoveredIndividuals,
    daySusceptibleIndividuals,
    configuration_options_scales_x_scaleLabel_labelString,
    configuration_options_scales_y_scaleLabel_labelString,
    configuration_options_title_text) {

    const context = document.getElementById(canvas).getContext('2d');
    context.canvas.width = context_canvas_width;
    context.canvas.height = context_canvas_height;

    const color = Chart.helpers.color;

    let dayCumulativeDiseaseInducedDeaths_Dataset = {
        label: 'Beijing',
        backgroundColor: color(window.chartColors.orange).alpha(0.5).rgbString(),
        borderColor: window.chartColors.orange,
        data: GenerateData(
            days,
            dayCumulativeDiseaseInducedDeaths),
        type: 'line',
        pointRadius: 0,
        fill: false,
        lineTension: 0,
        borderWidth: 2
    };

    let dayAsymptomaticIndividuals_Dataset = {
        label: 'Asymptomatic Individuals',
        backgroundColor: color(window.chartColors.red).alpha(0.5).rgbString(),
        borderColor: window.chartColors.red,
        data: GenerateData(
            days,
            dayAsymptomaticIndividuals),
        type: 'line',
        pointRadius: 0,
        fill: false,
        lineTension: 0,
        borderWidth: 2
    };

    let daySymptomaticIndividuals_Dataset = {
        label: 'Symptomatic Individuals',
        backgroundColor: color(window.chartColors.orange).alpha(0.5).rgbString(),
        borderColor: window.chartColors.orange,
        data: GenerateData(
            days,
            daySymptomaticIndividuals),
        type: 'line',
        pointRadius: 0,
        fill: false,
        lineTension: 0,
        borderWidth: 2
    };

    let dayIsolatedIndividuals_Dataset = {
        label: 'Isolated Individuals',
        backgroundColor: color(window.chartColors.yellow).alpha(0.5).rgbString(),
        borderColor: window.chartColors.yellow,
        data: GenerateData(
            days,
            dayIsolatedIndividuals),
        type: 'line',
        pointRadius: 0,
        fill: false,
        lineTension: 0,
        borderWidth: 2
    };

    let dayQuarantinedIndividuals_Dataset = {
        label: 'Quarantined Individuals',
        backgroundColor: color(window.chartColors.green).alpha(0.5).rgbString(),
        borderColor: window.chartColors.green,
        data: GenerateData(
            days,
            dayQuarantinedIndividuals),
        type: 'line',
        pointRadius: 0,
        fill: false,
        lineTension: 0,
        borderWidth: 2
    };

    let dayRecoveredIndividuals_Dataset = {
        label: 'Recovered Individuals',
        backgroundColor: color(window.chartColors.blue).alpha(0.5).rgbString(),
        borderColor: window.chartColors.blue,
        data: GenerateData(
            days,
            dayRecoveredIndividuals),
        type: 'line',
        pointRadius: 0,
        fill: false,
        lineTension: 0,
        borderWidth: 2
    };

    let daySusceptibleIndividuals_Dataset = {
        label: 'Susceptible Individuals',
        backgroundColor: color(window.chartColors.purple).alpha(0.5).rgbString(),
        borderColor: window.chartColors.purple,
        data: GenerateData(
            days,
            daySusceptibleIndividuals),
        type: 'line',
        pointRadius: 0,
        fill: false,
        lineTension: 0,
        borderWidth: 2
    };

    const configuration = {
        type: 'line',
        data: {
            labels: GenerateLabels(
                days),
            datasets: [
                dayAsymptomaticIndividuals_Dataset,
                daySymptomaticIndividuals_Dataset,
                dayIsolatedIndividuals_Dataset,
                dayQuarantinedIndividuals_Dataset,
                dayRecoveredIndividuals_Dataset,
                daySusceptibleIndividuals_Dataset]
        },
        options: {
            animation: {
                duration: 0
            },
            scales: {
                x: {
                    max: moment(days[days.length - 1]).valueOf(),
                    min: moment(days[0]).valueOf(),
                    type: 'timeseries',
                    title: {
                        display: true,
                        text: configuration_options_scales_x_scaleLabel_labelString
                    },
                    offset: true,
                    ticks: {
                        major: {
                            enabled: true,
                        },
                        fontStyle: 'bold',
                        source: 'auto',
                        autoSkip: true,
                        autoSkipPadding: 75,
                        maxRotation: 0,
                        sampleSize: 200
                    },
                },
                y: {
                    type: 'logarithmic',
                    gridLines: {
                        drawBorder: false
                    },
                    title: {
                        display: true,
                        text: configuration_options_scales_y_scaleLabel_labelString
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
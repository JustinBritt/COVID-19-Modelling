function GenerateData(days, values) {
    let data = [];

    let i = 0;

    for (; i < days.length; i++) {
        data.push(
            {
                x: luxon.DateTime.fromFormat(days[i], 'LLL dd yyyy').valueOf(),
                y: values[i]
            });
    }

    return data;
}

function GenerateChartGumel(
    canvas,
    days,
    dayCumulativeDiseaseInducedDeaths,
    dayAsymptomaticIndividuals,
    daySymptomaticIndividuals,
    dayIsolatedIndividuals,
    dayQuarantinedIndividuals,
    dayRecoveredIndividuals,
    daySusceptibleIndividuals) {

    const Beijing_Context = document.getElementById(canvas).getContext('2d');
    Beijing_Context.canvas.width = 1000;
    Beijing_Context.canvas.height = 300;

    const color = Chart.helpers.color;

    let Beijing_DayCumulativeDiseaseInducedDeaths_Dataset = {
        label: 'Beijing',
        backgroundColor: color(window.chartColors.orange).alpha(0.5).rgbString(),
        borderColor: window.chartColors.orange,
        data: GenerateData(days, dayCumulativeDiseaseInducedDeaths),
        type: 'line',
        pointRadius: 0,
        fill: false,
        lineTension: 0,
        borderWidth: 2
    };

    let Beijing_DayAsymptomaticIndividuals_Dataset = {
        label: 'Asymptomatic Individuals',
        backgroundColor: color(window.chartColors.red).alpha(0.5).rgbString(),
        borderColor: window.chartColors.red,
        data: GenerateData(days, dayAsymptomaticIndividuals),
        type: 'line',
        pointRadius: 0,
        fill: false,
        lineTension: 0,
        borderWidth: 2
    };

    let Beijing_DaySymptomaticIndividuals_Dataset = {
        label: 'Symptomatic Individuals',
        backgroundColor: color(window.chartColors.orange).alpha(0.5).rgbString(),
        borderColor: window.chartColors.orange,
        data: GenerateData(days, daySymptomaticIndividuals),
        type: 'line',
        pointRadius: 0,
        fill: false,
        lineTension: 0,
        borderWidth: 2
    };

    let Beijing_DayIsolatedIndividuals_Dataset = {
        label: 'Isolated Individuals',
        backgroundColor: color(window.chartColors.yellow).alpha(0.5).rgbString(),
        borderColor: window.chartColors.yellow,
        data: GenerateData(days, dayIsolatedIndividuals),
        type: 'line',
        pointRadius: 0,
        fill: false,
        lineTension: 0,
        borderWidth: 2
    };

    let Beijing_DayQuarantinedIndividuals_Dataset = {
        label: 'Quarantined Individuals',
        backgroundColor: color(window.chartColors.green).alpha(0.5).rgbString(),
        borderColor: window.chartColors.green,
        data: GenerateData(days, dayQuarantinedIndividuals),
        type: 'line',
        pointRadius: 0,
        fill: false,
        lineTension: 0,
        borderWidth: 2
    };

    let Beijing_DayRecoveredIndividuals_Dataset = {
        label: 'Recovered Individuals',
        backgroundColor: color(window.chartColors.blue).alpha(0.5).rgbString(),
        borderColor: window.chartColors.blue,
        data: GenerateData(days, dayRecoveredIndividuals),
        type: 'line',
        pointRadius: 0,
        fill: false,
        lineTension: 0,
        borderWidth: 2
    };

    let Beijing_DaySusceptibleIndividuals_Dataset = {
        label: 'Susceptible Individuals',
        backgroundColor: color(window.chartColors.purple).alpha(0.5).rgbString(),
        borderColor: window.chartColors.purple,
        data: GenerateData(days, daySusceptibleIndividuals),
        type: 'line',
        pointRadius: 0,
        fill: false,
        lineTension: 0,
        borderWidth: 2
    };

    const Beijing_Configuration = {
        data: {
            datasets: [
                Beijing_DayAsymptomaticIndividuals_Dataset,
                Beijing_DaySymptomaticIndividuals_Dataset,
                Beijing_DayIsolatedIndividuals_Dataset,
                Beijing_DayQuarantinedIndividuals_Dataset,
                Beijing_DayRecoveredIndividuals_Dataset,
                Beijing_DaySusceptibleIndividuals_Dataset]
        },
        options: {
            animation: {
                duration: 0
            },
            scales: {
                x: {
                    type: 'time',
                    distribution: 'series',
                    scaleLabel: {
                        display: true,
                        labelString: 'Day'
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
                    type: 'logarithmic',
                    gridLines: {
                        drawBorder: false
                    },
                    scaleLabel: {
                        display: true,
                        labelString: 'Number of People'
                    }
                }
            },
            title: {
                display: true,
                text: 'Beijing'
            },
            tooltips: {
                intersect: false,
                mode: 'index',
                callbacks: {
                    label: function (tooltipItem, myData) {
                        let label = myData.datasets[tooltipItem.datasetIndex].label || '';
                        if (label) {
                            label += ': ';
                        }
                        label += parseFloat(tooltipItem.value).toFixed(2);
                        return label;
                    }
                }
            }
        }
    };

    const Beijing_Chart = new Chart(
        Beijing_Context,
        Beijing_Configuration);
}
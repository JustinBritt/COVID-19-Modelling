function GenerateData_Gumel2006(days, values) {
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

function GenerateChart_Gumel2006(
    canvas,
    context_canvas_height,
    context_canvas_width,
    days,
    dayLatentIndividuals,
    configuration_options_scales_x_scaleLabel_labelString,
    configuration_options_scales_y_scaleLabel_labelString,
    configuration_options_title_text) {

    const context = document.getElementById(canvas).getContext('2d');
    context.canvas.width = context_canvas_width;
    context.canvas.height = context_canvas_height;

    const color = Chart.helpers.color;

    let dayLatentIndividuals_Dataset = {
        label: 'Latent Individuals',
        backgroundColor: color(window.chartColors.purple).alpha(0.5).rgbString(),
        borderColor: window.chartColors.purple,
        data: GenerateData_Gumel2006(days, dayLatentIndividuals),
        type: 'line',
        pointRadius: 0,
        fill: false,
        lineTension: 0,
        borderWidth: 2
    };

    const configuration = {
        data: {
            datasets: [
                dayLatentIndividuals_Dataset]
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
                    type: 'logarithmic',
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

    const chart = new Chart(
        context,
        configuration);
}
﻿/*!
 * chartjs-adapter-luxon v0.2.1
 * https://www.chartjs.org
 * (c) 2020 Chart.js Contributors
 * Released under the MIT license
 */
!function (e, t) { "object" == typeof exports && "undefined" != typeof module ? t(require("chart.js"), require("luxon")) : "function" == typeof define && define.amd ? define(["chart.js", "luxon"], t) : t((e = e || self).Chart, e.luxon) }(this, (function (e, t) { "use strict"; e = e && Object.prototype.hasOwnProperty.call(e, "default") ? e.default : e; const r = { datetime: t.DateTime.DATETIME_MED_WITH_SECONDS, millisecond: "h:mm:ss.SSS a", second: t.DateTime.TIME_WITH_SECONDS, minute: t.DateTime.TIME_SIMPLE, hour: { hour: "numeric" }, day: { day: "numeric", month: "short" }, week: "DD", month: { month: "short", year: "numeric" }, quarter: "'Q'q - yyyy", year: { year: "numeric" } }; e._adapters._date.override({ _id: "luxon", _create: function (e) { return t.DateTime.fromMillis(e, this.options) }, formats: function () { return r }, parse: function (r, n) { const i = this.options; if (e.helpers.isNullOrUndef(r)) return null; const o = typeof r; return "number" === o ? r = this._create(r) : "string" === o ? r = "string" == typeof n ? t.DateTime.fromFormat(r, n, i) : t.DateTime.fromISO(r, i) : "object" !== o || r instanceof t.DateTime ? r instanceof Date && (r = t.DateTime.fromJSDate(r, i)) : r = t.DateTime.fromObject(r), r.isValid ? r.valueOf() : null }, format: function (e, t) { const r = this._create(e); return "string" == typeof t ? r.toFormat(t, this.options) : r.toLocaleString(t) }, add: function (e, t, r) { const n = {}; return n[r] = t, this._create(e).plus(n).valueOf() }, diff: function (e, t, r) { return this._create(e).diff(this._create(t)).as(r).valueOf() }, startOf: function (e, t, r) { return "isoWeek" === t ? this._create(e).isoWeekday(r).valueOf() : t ? this._create(e).startOf(t).valueOf() : e }, endOf: function (e, t) { return this._create(e).endOf(t).valueOf() } }) }));
